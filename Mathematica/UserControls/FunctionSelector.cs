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

  public partial class FunctionSelector : UserControl
  {
    public event EventHandler ShapeComboChanged;
    //LinearFunction linearFunction;

    public string FunType
    {
      get;
      set;
    }
    public FunctionSelector()
    {
      InitializeComponent();
      linearFunction.Visible = false;
      quadraticFunction.Visible = false;
      

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      FunType = comboBox1.Text;
      if (this.FunType == "Linear function")
      {
        linearFunction.Visible = true;
        quadraticFunction.Visible = false;
      }
      else if (this.FunType == "Quadratic function")
      {
        linearFunction.Visible = false;
        quadraticFunction.Visible = true;
      }
    }

    private void FunctionSelector_Load(object sender, EventArgs e)
    {

    }

    private void linearFunction1_Load(object sender, EventArgs e)
    {

    }

    private void ApplyButton_Click(object sender, EventArgs e)
    {
      linearFunction.UpdatePoints();
      LinearFunctionModel model = new LinearFunctionModel(linearFunction.point_a, linearFunction.point_b, 0, 100);
    

    }

    private void quadraticFunction1_Load(object sender, EventArgs e)
    {

    }
  }
}
