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
    int [] tab;
    public List<int> Values { get;  set; } 

    public LinearFunctionModel(int a, int b, int minX, int maxX)
    {
      this.a = a;
      this.b = b;
      this.Values = new List<int>();
      for (int x = minX; x <= maxX; x++)
      {
        int wynik = a * x + b;
        Values.Add(wynik);
      }
    }

  }
}
