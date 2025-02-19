using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mathematica
{
  public partial class QuadraticFunction : UserControl
  {
    public QuadraticFunction()
    {
      InitializeComponent();

      result_label_quadratic.Text = "y" + "=" + a_quadratic.Value + "x" + "^2" + " " + "+" + b_quadratic.Value + "x" + " " + "+" + c_quadratic.Value;
   
    }

    private void QuadraticFunction_Load(object sender, EventArgs e)
    {

    }

    private void c_ValueChanged(object sender, EventArgs e)
    {

      result_label_quadratic.Text = "y" + "=" + a_quadratic.Value + "x" + "^2" + " " + "+" + b_quadratic.Value + "x" + " " + "+" + string.Format(c_quadratic.Value.ToString());
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void a_ValueChanged(object sender, EventArgs e)
    {
      result_label_quadratic.Text = "y" + "=" + string.Format(a_quadratic.Value.ToString()) + "x" + "^2" + " " + "+" + b_quadratic.Value + "x" + " " + "+" + c_quadratic.Value;
    }

    private void b_ValueChanged(object sender, EventArgs e)
    {
    //  result_label_quadratic.Text = ;
      result_label_quadratic.Text = "y" + "=" + a_quadratic.Value + "x" + "^2" + " " + "+" + string.Format(b_quadratic.Value.ToString()) + "x" + " " + "+" + c_quadratic.Value;
    }
  }
}
