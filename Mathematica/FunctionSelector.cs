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

    }

    private void FunctionSelector_Load(object sender, EventArgs e)
    {
      LinearFunction li =  new LinearFunction();
      li.Visible = true;
    }
  }
}
