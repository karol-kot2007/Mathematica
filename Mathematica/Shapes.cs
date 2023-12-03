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
        Pen pen = new Pen(Color.Red, 3);
        string shapeToDraw;
        public Shapes()
        {
            InitializeComponent();
            shapeSelector.DrawClicked += ShapeSelector_DrawClicked;
            shapeSelector.ShapeComboChanged += ShapeSelector_ShapeComboChanged;
            shapeSelector.ColorChanged += ShapeSelector_ColorChanged;

            shapeControl.ShapeSelector = shapeSelector;
        }

        private void ShapeSelector_ColorChanged(object? sender, EventArgs e)
        {
            ComboBox color = (ComboBox)sender;
            if(color.Text=="Blue")
            {
                pen.Color = Color.Blue;
                Redraw();
            }
            else if (color.Text == "Red")
            {
                pen.Color = Color.Red;
                Redraw();
            }
            else if (color.Text == "Green")
            {
                pen.Color = Color.Green;
                Redraw();
            }
        }

        void Redraw()
        {
            shapeControl.Invalidate();
            shapeControl.Update();

            //var size = shapeControl1.Size;
            //size.Width += 100;
            //shapeControl1.Size = size;
        }

        private void ShapeSelector_ShapeComboChanged(object? sender, EventArgs e)
        {
            Redraw();
        }

        private void ShapeSelector_DrawClicked(object? sender, EventArgs e)
        {
            Redraw();
        }

       

        private void Shapes_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void DrawCircle1(PaintEventArgs e)
        {
            // Create pen.
          

            // Create rectangle for ellipse.
            RectangleF rect = new RectangleF(100.0F, 0.0F, 100.0F, 100.0F);

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(pen, rect);

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
            e.Graphics.DrawLines(pen, points.ToArray());
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
            e.Graphics.DrawLines(pen, points.ToArray());
        }
//        private void buttonRedraw_Click(object sender, EventArgs e)
//        {
////           
//           

//        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void shapeSelector1_Load(object sender, EventArgs e)
        {

        }
    }

}
