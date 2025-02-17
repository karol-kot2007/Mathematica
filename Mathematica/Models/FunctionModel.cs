using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica.Models
{
 internal class FunctionModel
  {
    enum FunctionKind { Unset, Linear, Quadratic }
    int MinX = 100;
    int MaxX = 100;
    Dictionary<int , int > Values;// key of dict is x, value is y

  }
}
