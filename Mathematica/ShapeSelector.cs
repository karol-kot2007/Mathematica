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
        public ShapeSelector()
        {
            InitializeComponent();
        }

        private void DrawClick(object sender, EventArgs e)
        {
            if (DrawClicked != null)
                DrawClicked(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
