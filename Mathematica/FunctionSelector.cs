﻿using Mathematica.Models;
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
    LinearFunction linearFunction;

    public string FunType
    {
      get;
      set;
    }
    public FunctionSelector()
    {
      InitializeComponent();
      linearFunction1.Visible = false;
      quadraticFunction1.Visible = false;
      linearFunction = new LinearFunction();

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      FunType = comboBox1.Text;
      if (this.FunType == "Linear function")
      {
        linearFunction1.Visible = true;
        quadraticFunction1.Visible = false;
      }
      else if (this.FunType == "Quadratic function")
      {
        linearFunction1.Visible = false;
        quadraticFunction1.Visible = true;
      }
    }

    private void FunctionSelector_Load(object sender, EventArgs e)
    {

    }

    private void linearFunction1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      linearFunction.UpdatePoints();
      LinearFunctionModel model = new LinearFunctionModel(linearFunction.point_a, linearFunction.point_b, 0, 100);
      if (linearFunction.point_a > 10)
      {
        Application.Exit();
      }

    }

    private void quadraticFunction1_Load(object sender, EventArgs e)
    {

    }
  }
}
