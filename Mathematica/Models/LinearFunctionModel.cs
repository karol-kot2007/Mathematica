using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica.Models
{
  public class LinearFunctionModel : FunctionModel
  {
    public FunctionKind Kind { get; set; }
    int a;
    int b;
    public LinearFunctionModel(int a, int b, int minX = 0, int maxX = 100)
    {
      Kind = FunctionKind.Linear;
      this.a = a;
      this.b = b;
      this.Values = new List<int>();
      for (int x = minX; x <= maxX; x++)
      {
        int wynik = a * x + b;
        Values.Add(wynik);
      }
     
    }
    public override void CalculateY(int minX=0, int maxX = 100)
    {
      Kind = FunctionKind.Linear;
      this.a = a;
      this.b = b;
      this.Values = new List<int>();
      for (int x = minX; x <= maxX; x++)
      {
        int wynik = a * x + b;
        Values.Add(wynik);
      }
    }
    public void Calculate(int minX, int maxX)
    {


    }
    public  override int GetY(int x)
    {
      return a*x +b;  
    }
  }
}
