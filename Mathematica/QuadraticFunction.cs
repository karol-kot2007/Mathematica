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
  public partial class QuadraticFunction : UserControl
  {
    public QuadraticFunction()
    {
      InitializeComponent();

      result_label_quadratic.Text ="y"+ "="+ a.Value + "x" + "^2" + " " + "+" + b.Value +"x"+ " " + "+" + c.Value;
    }

    private void QuadraticFunction_Load(object sender, EventArgs e)
    {

    }

    private void numericUpDown3_ValueChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}
