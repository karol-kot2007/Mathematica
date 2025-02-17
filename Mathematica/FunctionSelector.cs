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
  public partial class FunctionSelector : UserControl
  {
    public FunctionSelector()
    {
      InitializeComponent();
      
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBox1.SelectedIndex == 0)
      {
        linearFunction1.Visible = true;
      }
      else if (comboBox1.SelectedIndex == 1)
      {
        quadraticFunction1.Visible = true;
      }
    }

    private void FunctionSelector_Load(object sender, EventArgs e)
    {
      //LinearFunction linearFunction = new LinearFunction();
      //linearFunction.Visible = false;
    }

    private void linearFunction1_Load(object sender, EventArgs e)
    {
      LinearFunction linearFunction = new LinearFunction();
      linearFunction.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void quadraticFunction1_Load(object sender, EventArgs e)
    {
      quadraticFunction1 = new QuadraticFunction();
      quadraticFunction1.Visible = false;
    }
  }
}
