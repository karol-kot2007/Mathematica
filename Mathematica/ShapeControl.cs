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
       public Pen Pen = new Pen(Color.Red, 3);
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
                DrawCircle1(e);
                DrawCircle2(e);
            }

            else if (ShapeSelector.ShapeKind == "triangle")
            {

                e.Graphics.DrawLine(Pen, ShapeSelector.Point1, ShapeSelector.Point2);
                e.Graphics.DrawLine(Pen, ShapeSelector.Point2, ShapeSelector.Point3);
                e.Graphics.DrawLine(Pen, ShapeSelector.Point3, ShapeSelector.Point1);
            }

        }
        public void DrawLinePointF(PaintEventArgs e)
        {


            e.Graphics.DrawLine(Pen, ShapeSelector.Point1, ShapeSelector.Point2);
        }
        private void DrawCircle1(PaintEventArgs e)
        {
            // Create pen.


            // Create rectangle for ellipse.
            RectangleF rect = new RectangleF(100.0F, 0.0F, 100.0F, 100.0F);

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(Pen, rect);

        }
        private void DrawCircle2(PaintEventArgs e)
        {
            List<PointF> points = new List<PointF>();
            //  points.Add(new PointF(100.0F, 100.0F));
            // points.Add(new PointF(100.0F, 101.0F));
            for (float angRad = 0; angRad < 2 * Math.PI; angRad += 0.01f)
            {
                //float angRad = MathF.Cos((float)Math.PI * angDegreess / 180.0F);

                PointF point = new PointF(MathF.Sin(angRad) * 50, MathF.Cos(angRad) * 50);
                point = PointF.Add(point, new Size(100, 100));
                points.Add(point);
            }
            e.Graphics.DrawLines(Pen, points.ToArray());
        }

        private void DrawCircle3(PaintEventArgs e)
        {
            List<PointF> points = new List<PointF>();
            //  points.Add(new PointF(100.0F, 100.0F));
            // points.Add(new PointF(100.0F, 101.0F));
            for (float angRad = 0; angRad < 2 * Math.PI; angRad += 0.01f)
            {
                //float angRad = MathF.Cos((float)Math.PI * angDegreess / 180.0F);

                PointF point = new PointF(MathF.Sin(angRad) * 50, MathF.Cos(angRad) * 50);
                point = PointF.Add(point, new Size(100, 100));
                points.Add(point);
            }
            e.Graphics.DrawLines(Pen, points.ToArray());
        }
    }
}
