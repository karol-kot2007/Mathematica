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
    public partial class ShapeSelector : UserControl
    {
        public event EventHandler DrawClicked;
        public string ShapeKind { 
            get; 
            set; 
        }
        
        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }
        public ShapeSelector()
        {
            InitializeComponent();
        }

        private void DrawClick(object sender, EventArgs e)
        {
            Point1 = new PointF(float.Parse(Point1XTxt.Text), float.Parse( Point1YTxt.Text));
            Point2 = new PointF(float.Parse(Point2XTxt.Text),float.Parse(Point2YTxt.Text));
            if (DrawClicked != null)
                DrawClicked(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShapeKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShapeKind=ShapeKindCb.Text;
            //Point2XTxt.Visible
            if (this.ShapeKind == "lines")
            {
             
                RadiusTxt.Visible= false;
                Point1XTxt.Visible = true;
                Point2XTxt.Visible = true;
                Point2YTxt.Visible = true;
                Point1YTxt.Visible = true;
            }
            else if (this.ShapeKind == "circle")
            {
                RadiusTxt.Visible = true;
                Point1XTxt.Visible = false;
                Point2XTxt.Visible= false;
                Point2YTxt.Visible = false;
                Point1YTxt.Visible = false;
                labelYF.Visible = false;
                labelYT.Visible = false;
                labelXT.Visible = false;
                labelXF.Visible = false;
            }
        }

        private void Radius_Click(object sender, EventArgs e)
        {

        }
    }
}
