﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
  internal class Line
  {
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
      Start = start;
      End = end;
    }
  }

}
