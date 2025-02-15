﻿using System;
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
    public partial class FunctionChart : UserControl
    {
        public Point ChartLineYTop { get; set; }
        public Point ChartLineYBottom { get; set; }

        public Point ChartLineXLeft { get; set; }
        public Point ChartLineXRight { get; set; }

        internal Line AxisY { get; set; }
        internal Line AxisX { get; set; }

        internal Arrow ArrowY { get; set; }
        internal Arrow ArrowX { get; set; }
    List<Line>  chartAxisLines;



        public FunctionChart()
        {
            InitializeComponent();

            
        }

   public void createChartAxisX()
    {
      AxisX = new Line(ChartLineXLeft, ChartLineXRight);
      ArrowX = new Arrow();
      var ptX = ChartLineXLeft;
      ptX.X = ptX.X - 6;
      ArrowX.Line1 = new Line(ptX, ChartLineXLeft);
    }

    public void createChartAxisY()
    {
      AxisY = new Line(ChartLineYTop, ChartLineYBottom);
      ArrowY = new Arrow();
      var pt = ChartLineYTop;
      pt.X = pt.X - 6;
      pt.Y = pt.Y + 10;
      ArrowY.Line1 = new Line(pt, ChartLineYTop);
      pt.X = pt.X + 12;
      ArrowY.Line2 = new Line(ChartLineYTop, pt);
    }
    private void createChartAxis(object sender, EventArgs e)
    {
    
     
  

    
      
     
      chartAxisLines = new List<Line>();
      createChartAxisX();
      createChartAxisY();

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FunctionChart_Paint(object sender, PaintEventArgs e)
        {
            foreach(var line in chartAxisLines)
            {
                e.Graphics.DrawLine(Pens.Gray, line.Start, line.End);
            }
            //e.Graphics.DrawLine(Pens.Gray, AxisY.Start, AxisY.End);
            //e.Graphics.DrawLine(Pens.Gray, AxisX.Start, AxisX.End);
            //e.Graphics.DrawLine(Pens.Gray, ArrowY.Line1.Start, ArrowY.Line1.End);
            //e.Graphics.DrawLine(Pens.Gray, ArrowY.Line2.Start, ArrowY.Line2.End);
        }
    }
}
