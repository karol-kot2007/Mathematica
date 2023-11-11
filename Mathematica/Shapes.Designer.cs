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
            this.shapeSelector = new Mathematica.ShapeSelector();
            this.SuspendLayout();
            // 
            // shapeSelector
            // 
            this.shapeSelector.Dock = System.Windows.Forms.DockStyle.Right;
            this.shapeSelector.Location = new System.Drawing.Point(465, 0);
            this.shapeSelector.Name = "shapeSelector";
            this.shapeSelector.Size = new System.Drawing.Size(335, 450);
            this.shapeSelector.TabIndex = 9;
            this.shapeSelector.Load += new System.EventHandler(this.shapeSelector1_Load);
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shapeSelector);
            this.Name = "Shapes";
            this.Text = "Shapes";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Shapes_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private ShapeSelector shapeSelector;
    }
}