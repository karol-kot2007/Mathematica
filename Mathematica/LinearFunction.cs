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
    public LinearFunction()
    {
      InitializeComponent();

      result_label_linear.Text = "y" + "=" + a.Value + "*x" + " + " + b.Value;
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

    }
  }
}
