using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematica
{
  public partial class FunctionChart : UserControl
  {
    public Point ChartLineYTop { get; set; }
    public Point ChartLineYBottom { get; set; }
    public Point ChartLineXLeft { get; set; }
    public Point ChartLineXRight { get; set; }
    internal Line AxisY { get; set; }
    internal Line AxisX { get; set; }
    internal Arrow ArrowY { get; set; }
    internal Arrow ArrowX { get; set; }
    List<Line> chartAxisLines;



    public FunctionChart()
    {
      InitializeComponent();
    }

    public void createChartAxisX()
    {
      AxisX = new Line(ChartLineXLeft, ChartLineXRight);
      ArrowX = new Arrow();
      var pt = ChartLineXLeft;

      pt.Y = pt.Y - 6;
      pt.X = pt.X + 10;
      ArrowX.Line1 = new Line(pt, ChartLineXRight);

      pt.Y = pt.Y + 12;
      ArrowY.Line2 = new Line(ChartLineXRight, pt);
      //pt.X = pt.X - 6;
      //pt.Y = pt.Y + 10;
      //pt.X = pt.X + 12;
    }

    public void createChartAxisY()
    {
      AxisY = new Line(ChartLineYTop, ChartLineYBottom);
      ArrowY = new Arrow();
      var pt = ChartLineYTop;
      pt.X = pt.X - 6;
      pt.Y = pt.Y + 10;
      ArrowY.Line1 = new Line(pt, ChartLineYTop);
      pt.X = pt.X + 12;
      ArrowY.Line2 = new Line(ChartLineYTop, pt);
    }
    private void createChartAxis(object sender, EventArgs e)
    {
      chartAxisLines = new List<Line>();
      createChartAxisX();
      createChartAxisY();
    }
    private void funchart_Load(object sender, EventArgs e)
    {
      AxisX = new Line(ChartLineXLeft, ChartLineXRight);
      AxisY = new Line(ChartLineYTop, ChartLineYBottom);
      ArrowY = new Arrow();
      ArrowX = new Arrow();
      var pt = ChartLineYTop;
      var pt2 = ChartLineXRight;
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

      chartAxisLines = new List<Line>();
      chartAxisLines.Add(AxisX);
      chartAxisLines.Add(AxisY);
      chartAxisLines.Add(ArrowY.Line1);
      chartAxisLines.Add(ArrowY.Line2);
      chartAxisLines.Add(ArrowX.Line1);
      chartAxisLines.Add(ArrowX.Line2);
    }
    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void FunctionChart_Paint(object sender, PaintEventArgs e)
    {
      foreach (var line in chartAxisLines)
      {
        e.Graphics.DrawLine(Pens.Gray, line.Start, line.End);
      }
      //e.Graphics.DrawLine(Pens.Gray, AxisY.Start, AxisY.End);
      //e.Graphics.DrawLine(Pens.Gray, AxisX.Start, AxisX.End);
      //e.Graphics.DrawLine(Pens.Gray, ArrowY.Line1.Start, ArrowY.Line1.End);
      //e.Graphics.DrawLine(Pens.Gray, ArrowY.Line2.Start, ArrowY.Line2.End);
    }
  }
}
