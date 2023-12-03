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
        //Pen pen = new Pen(Color.Red, 3);
        string shapeToDraw;
        public Shapes()
        {
            InitializeComponent();
            shapeSelector.DrawClicked += ShapeSelector_DrawClicked;
            shapeSelector.ShapeComboChanged += ShapeSelector_ShapeComboChanged;
            shapeSelector.ColorChanged += ShapeSelector_ColorChanged;

            shapeControl1.ShapeSelector = shapeSelector;
        }

        private void ShapeSelector_ColorChanged(object? sender, EventArgs e)
        {
            ComboBox color = (ComboBox)sender;
            if(color.Text=="Blue")
            {
                shapeControl1.Pen.Color = Color.Blue;
                Redraw();
            }
            else if (color.Text == "Red")
            {
                shapeControl1.Pen.Color = Color.Red;
                Redraw();
            }
            else if (color.Text == "Green")
            {
                shapeControl1.Pen.Color = Color.Green;
                Redraw();
            }
        }

        void Redraw()
        {
            shapeControl1.Invalidate();
            shapeControl1.Update();

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
