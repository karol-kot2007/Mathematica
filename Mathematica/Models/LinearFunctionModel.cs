using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica.Models
{
  public class LinearFunctionModel : FunctionModel
  {
    
    int a;
    int b;
    public LinearFunctionModel(int a, int b, int minX = 0, int maxX = 100)
    {
      Kind = FunctionKind.Linear;
      this.a = a;
      this.b = b;
      CalculateY(); 
    }
    public override void CalculateY()
    {
      this.AxisYValues.Clear();
      for (int x = MinX; x <= MaxX; x++)
      {
        int wynik = a* x + b;
        AxisYValues.Add(wynik);
      }
    }
    public  override int GetY(int x)
    {
      return AxisYValues[x];  
    }
  }
}
