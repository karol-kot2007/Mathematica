using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Mathematica
{


  public partial class FunctionChartForm : Form
  {
    public FunctionChartForm()
    {
      InitializeComponent();
      functionSelector1.ApplyModel += FunctionSelector1_ApplyModel; ;
    }

    private void FunctionSelector1_ApplyModel(object? sender, Models.FunctionModel e)
    {
      functionChart1.SetModel(e);
    }

    private void functionSelector1_Load(object sender, EventArgs e)
    {

    }

    private void functionChart1_Load(object sender, EventArgs e)
    {

    }
  }
}