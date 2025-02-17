using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica.Models
{
  internal class LinearFunctionModel : FunctionModel
  {
    int a=2;
    int b=1;
    
    public LinearFunctionModel(int a, int b)
    {
      this.a = a;
      this.b = b;
    }
    public void Calculate(int minX,int maxX)
    {
   
      for (int x = minX; x <= maxX;x++)
      {
        int wynik = a * x + b;
      }
    }
  }
}
