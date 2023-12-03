namespace Mathematica
{
    partial class Shapes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shapes));
            this.shapeSelector = new Mathematica.ShapeSelector();
            this.shapeControl1 = new Mathematica.ShapeControl();
            this.SuspendLayout();
            // 
            // shapeSelector
            // 
            this.shapeSelector.Dock = System.Windows.Forms.DockStyle.Right;
            this.shapeSelector.Location = new System.Drawing.Point(465, 0);
            this.shapeSelector.Name = "shapeSelector";
            this.shapeSelector.Point1 = ((System.Drawing.PointF)(resources.GetObject("shapeSelector.Point1")));
            this.shapeSelector.Point2 = ((System.Drawing.PointF)(resources.GetObject("shapeSelector.Point2")));
            this.shapeSelector.Point3 = ((System.Drawing.PointF)(resources.GetObject("shapeSelector.Point3")));
            this.shapeSelector.ShapeKind = null;
            this.shapeSelector.Size = new System.Drawing.Size(335, 450);
            this.shapeSelector.TabIndex = 9;
            this.shapeSelector.Load += new System.EventHandler(this.shapeSelector1_Load);
            // 
            // shapeControl1
            // 
            this.shapeControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapeControl1.Location = new System.Drawing.Point(2, 0);
            this.shapeControl1.Name = "shapeControl1";
            this.shapeControl1.Size = new System.Drawing.Size(398, 426);
            this.shapeControl1.TabIndex = 13;
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shapeControl1);
            this.Controls.Add(this.shapeSelector);
            this.Name = "Shapes";
            this.Text = "Shapes";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Shapes_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private ShapeSelector shapeSelector;
        private ShapeControl shapeControl1;
    }
}