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
    public partial class ShapeControl : UserControl
    {
        Pen pen = new Pen(Color.Red, 3);
        public ShapeSelector ShapeSelector { get; set; }
        public ShapeControl()
        {
            InitializeComponent();
            
        }

        private void ShapeControl_Paint(object sender, PaintEventArgs e)
        {
            if (ShapeSelector == null)
                return;

            if (ShapeSelector.ShapeKind == "lines")
            {
                DrawLinePointF(e);
            }
            else if (ShapeSelector.ShapeKind == "circle")
            {
               // DrawCircle1(e);
              //  DrawCircle2(e);
            }

            else if (ShapeSelector.ShapeKind == "triangle")
            {

                //e.Graphics.DrawLine(pen, shapeSelector.Point1, shapeSelector.Point2);
                //e.Graphics.DrawLine(pen, shapeSelector.Point2, shapeSelector.Point3);
                //e.Graphics.DrawLine(pen, shapeSelector.Point3, shapeSelector.Point1);
            }

        }
        public void DrawLinePointF(PaintEventArgs e)
        {


            e.Graphics.DrawLine(pen, ShapeSelector.Point1, ShapeSelector.Point2);
        }
    }
}
