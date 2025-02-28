using Mathematica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematica
{
  public partial class FunctionChart : UserControl
  {
    public Pen Pen = new Pen(Color.Red, 3);
    public Point ChartLineYTop { get; set; }
    public Point ChartLineYBottom { get; set; }
    public Point ChartLineXLeft { get; set; }
    public Point ChartLineXRight { get; set; }
    public FunctionModel Model { get; private set; }
    public LinearFunction linearFunction { get; set; }
    internal Line AxisY { get; set; }
    internal Line AxisX { get; set; }
    internal Arrow ArrowY { get; set; }
    internal Arrow ArrowX { get; set; }

    List<Line>  chartAxisLines = new List<Line>();
    List<Point> Points = new();
    public FunctionModel FunctionModel { get; set; }
    Pen pen = new Pen(Color.DarkRed);
  
    public void SetModel(FunctionModel model)
    {
      Model = model;
      Points.Clear();
      for (var x = 0; x < model.AxisYValues.Count; x++)
      {
        Points.Add(new Point(x, Height- model.AxisYValues[x]));
      }
      Refresh();
    }
    public FunctionChart()
    {
      InitializeComponent();
      Refresh();
    }
    protected override void OnPaint(PaintEventArgs e)
    {
      var model = FunctionModel;
      base.OnPaint(e);
      for (var pointIndex = 0; pointIndex < Points.Count; pointIndex++)
      {
        if (pointIndex< Points.Count - 1)
        {
          Point point1 = Points[pointIndex];
          Point point2 = Points[pointIndex + 1];
          //add x offset of x axis
          e.Graphics.DrawLine(pen, point1, point2);
        }
      }
    }
    public void createArrows()
    {
      var pt2 = ChartLineXRight;
      var pt = ChartLineYTop;
      ArrowY = new Arrow();
      ArrowX = new Arrow();
      pt.X = pt.X - 6;
      pt.Y = pt.Y + 10;
      ArrowY.Line1 = new Line(pt, ChartLineYTop);
      pt.X = pt.X + 12;
      ArrowY.Line2 = new Line(ChartLineYTop, pt);
      pt2.X = pt2.X - 7;
      pt2.Y = pt2.Y - 7;
      ArrowX.Line1 = new Line(pt2, ChartLineXRight);
      pt2.Y = pt2.Y + 14;
      ArrowX.Line2 = new Line(ChartLineXRight, pt2);
      chartAxisLines.Add(ArrowY.Line1);
      chartAxisLines.Add(ArrowY.Line2);
      chartAxisLines.Add(ArrowX.Line1);
      chartAxisLines.Add(ArrowX.Line2);
    }

    private void createXaxis()
    {
      AxisX = new Line(ChartLineXLeft, ChartLineXRight);
      chartAxisLines.Add(AxisX);
    }

    private void createYaxis()
    {
      AxisY = new Line(ChartLineYTop, ChartLineYBottom);
      chartAxisLines.Add(AxisY);
    }
    private void funchart_Load(object sender, EventArgs e)
    {
      createXaxis();
      createYaxis();
      createArrows();
    }
    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void FunctionChart_Paint(object sender, PaintEventArgs e)
    {
      foreach (var line  in chartAxisLines )
      {
      
        e.Graphics.DrawLine(Pens.Gray, line.Start , line.End);
      }
    }
  }
}
