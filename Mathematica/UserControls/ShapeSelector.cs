using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematica
{

  public partial class ShapeSelector : UserControl
  {
    public event EventHandler ColorChanged;
    public event EventHandler DrawClicked;
    public event EventHandler ShapeComboChanged;
    public string ShapeKind
    {
      get;
      set;
    }

    public PointF Point1 { get; set; }
    public PointF Point2 { get; set; }
    public PointF Point3 { get; set; }
    public ShapeSelector()
    {
      InitializeComponent();
    }

    private void DrawClick(object sender, EventArgs e)
    {
      ViewToModel();
      if (DrawClicked != null)
        DrawClicked(this, EventArgs.Empty);
    }

    private void ViewToModel()
    {
      Point1 = new PointF(float.Parse(Point1XTxt.Text), float.Parse(Point1YTxt.Text));
      Point2 = new PointF(float.Parse(Point2XTxt.Text), float.Parse(Point2YTxt.Text));
      Point3 = new PointF(float.Parse(Point3XTxt.Text), float.Parse(Point3YTxt.Text));
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void ShapeKind_SelectedIndexChanged(object sender, EventArgs e)
    {
      ShapeKind = ShapeKindCb.Text;
      //Point2XTxt.Visible
      if (this.ShapeKind == "lines")
      {

        RadiusTxt.Visible = false;
        Point1XTxt.Visible = true;
        Point2XTxt.Visible = true;
        Point2YTxt.Visible = true;
        Point1YTxt.Visible = true;
        Point3XTxt.Visible = false;
        Point3YTxt.Visible = false;
        labelX3.Visible = false;
        labelX2.Visible = true;

        label1.Visible = true;
        label2.Visible = true;
        label3.Visible = false;
        Radius.Visible = false;
        labelX1.Visible = true;
        labelY3.Visible = false;
        labelY2.Visible = true;
        labelY1.Visible = true;
      }
      else if (this.ShapeKind == "circle")
      {
        RadiusTxt.Visible = true;
        Point1XTxt.Visible = false;
        Point2XTxt.Visible = false;
        Point2YTxt.Visible = false;
        Point1YTxt.Visible = false;
        labelY1.Visible = false;
        labelY2.Visible = false;
        //  labelXT.Visible = false;
        labelX3.Visible = false;
        //   textX.Visible = false;
        Point3YTxt.Visible = false;
        //   textBox1.Visible = false;
        //   textBox2.Visible = false;
        Point3XTxt.Visible = false;
        label1.Visible = false;
        label2.Visible = false;
        label3.Visible = false;
        Radius.Visible = true;
        labelX2.Visible = false;
        labelX1.Visible = false;
        //    Xlabel.Visible = false;
        labelY3.Visible = false;
      }
      else if (this.ShapeKind == "triangle")
      {
        RadiusTxt.Visible = false;
        Point1XTxt.Visible = true;
        Point2XTxt.Visible = true;
        Point3XTxt.Visible = true;
        Point3YTxt.Visible = true;
        Point1YTxt.Visible = true;
        Point2YTxt.Visible = true;
        labelY1.Visible = true;
        labelY2.Visible = true;
        labelY3.Visible = true;
        label3.Visible = true;
        label2.Visible = true;
        label1.Visible = true;

        Radius.Visible = false;
      }
      ShapeComboChanged(this, ErrorEventArgs.Empty);
    }

    private void Radius_Click(object sender, EventArgs e)
    {

    }

    private void Point3_Click(object sender, EventArgs e)
    {

    }

    private void Point2_Click(object sender, EventArgs e)
    {

    }

    private void ShapeSelector_Load(object sender, EventArgs e)
    {
      ViewToModel();
    }

    private void ColorCb_SelectedIndexChanged(object sender, EventArgs e)
    {
      ColorChanged(ColorCb, EventArgs.Empty);
    }

    private void Point1XTxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void Point3XTxt_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
