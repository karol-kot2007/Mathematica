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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void charts_Click(object sender, EventArgs e)
    {
      FunctionChartForm f2 = new FunctionChartForm();
      f2.Show();
    
    }

    private void shapes_Click(object sender, EventArgs e)
    {
      Shapes f2 = new Shapes();
      f2.Show();
     
    }
  }
}
