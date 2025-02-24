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
  public partial class LinearFunction : UserControl
  {
    public int point_a { get; set; }
    public int point_b { get; set; }


    public LinearFunction()
    {
      InitializeComponent();
      result_label_linear.Text = "y" + "=" + a_linear.Value + "*x" + " + " + b_linear.Value;


    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void a_ValueChanged(object sender, EventArgs e)
    {
      result_label_linear.Text = "y" + "=" + string.Format(a_linear.Value.ToString()) + "*x" + " + " + b_linear.Value;
      point_a = (int)a_linear.Value;
      //if (point_a > 10)
      //{
      //  Application.Exit();
      //}
    }


    private void b_linear_ValueChanged(object sender, EventArgs e)
    {
      result_label_linear.Text = "y" + "=" + a_linear.Value + "*x" + " + " + string.Format(b_linear.Value.ToString());
      point_b = (int)b_linear.Value;
      //if (point_b > 10)
      //{
      //  Application.Exit();
      //}
    }
    public void UpdatePoints()
    {
      point_a = (int)a_linear.Value;
      point_b = (int)b_linear.Value;
    }
  }
}
