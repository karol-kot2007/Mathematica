using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematica
{
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
        }

        public void DrawLinePointF(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            //PointF point1 = new PointF(float.Parse(textBoxXFrom.Text), 100.0F);
            //PointF point2 = new PointF(float.Parse(textBoxYfrom.Text), 100.0F);
            //PointF point3 = new PointF(float.Parse(Xto.Text), 10.0F);
            //PointF point4 = new PointF(float.Parse(Yto.Text), 10.0F);
            // Draw line to screen.
           // e.Graphics.DrawLine(blackPen, point1, point2);
        }

        private void Shapes_Paint(object sender, PaintEventArgs e)
        {
            DrawLinePointF(e);
            DrawCircle1( e);
            DrawCircle2(e);
        }
        private void DrawCircle1(PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle for ellipse.
            RectangleF rect = new RectangleF(100.0F, 0.0F, 100.0F, 100.0F);

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(blackPen, rect);

        }
        private void DrawCircle2(PaintEventArgs e)
        {
            List<PointF> points  = new List<PointF>();
          //  points.Add(new PointF(100.0F, 100.0F));
           // points.Add(new PointF(100.0F, 101.0F));
           for(float angRad = 0; angRad < 2* Math.PI; angRad += 0.01f)
            {
                //float angRad = MathF.Cos((float)Math.PI * angDegreess / 180.0F);
                 
                PointF point = new PointF(MathF.Sin(angRad) * 50, MathF.Cos(angRad) * 50);
                point = PointF.Add(point, new Size(100,100));
                points.Add(point);
            }
            e.Graphics.DrawLines(Pens.Red, points.ToArray());
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void shapeSelector1_Load(object sender, EventArgs e)
        {

        }
    }

}
