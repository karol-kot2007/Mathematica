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
    public partial class FunctionChart : UserControl
    {
        public Point ChartLineYTop { get; set; }
        public Point ChartLineYBottom { get; set; }

        public Point ChartLineXLeft { get; set; }
        public Point ChartLineXRight { get; set; }

        internal Line AxisY { get; set; }
        internal Line AxisX { get; set; }
        public FunctionChart()
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void funchart_Load(object sender, EventArgs e)
        {
            AxisX = new Line(ChartLineXLeft, ChartLineXRight);
            AxisY = new Line(ChartLineYTop, ChartLineYBottom);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FunctionChart_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawLine(Pens.Gray, AxisY.Start, AxisY.End);
            e.Graphics.DrawLine(Pens.Gray, AxisX.Start, AxisX.End);
        }
    }
}
