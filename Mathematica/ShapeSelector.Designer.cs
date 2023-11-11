namespace Mathematica
{
    partial class ShapeSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShapeKindCb = new System.Windows.Forms.ComboBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.labelYT = new System.Windows.Forms.Label();
            this.labelXT = new System.Windows.Forms.Label();
            this.Point2YTxt = new System.Windows.Forms.TextBox();
            this.Point2XTxt = new System.Windows.Forms.TextBox();
            this.labelYF = new System.Windows.Forms.Label();
            this.Point1YTxt = new System.Windows.Forms.TextBox();
            this.labelXF = new System.Windows.Forms.Label();
            this.Point1XTxt = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.Label();
            this.RadiusTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShapeKindCb
            // 
            this.ShapeKindCb.AccessibleName = "ShapeType ";
            this.ShapeKindCb.FormattingEnabled = true;
            this.ShapeKindCb.Items.AddRange(new object[] {
            "lines",
            "circle"});
            this.ShapeKindCb.Location = new System.Drawing.Point(4, 3);
            this.ShapeKindCb.Name = "ShapeKindCb";
            this.ShapeKindCb.Size = new System.Drawing.Size(121, 23);
            this.ShapeKindCb.TabIndex = 0;
            this.ShapeKindCb.SelectedIndexChanged += new System.EventHandler(this.ShapeKind_SelectedIndexChanged);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(3, 230);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 23);
            this.drawBtn.TabIndex = 1;
            this.drawBtn.Text = "draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.DrawClick);
            // 
            // labelYT
            // 
            this.labelYT.AutoSize = true;
            this.labelYT.Location = new System.Drawing.Point(200, 95);
            this.labelYT.Name = "labelYT";
            this.labelYT.Size = new System.Drawing.Size(27, 15);
            this.labelYT.TabIndex = 16;
            this.labelYT.Text = "y to";
            // 
            // labelXT
            // 
            this.labelXT.AutoSize = true;
            this.labelXT.Location = new System.Drawing.Point(3, 95);
            this.labelXT.Name = "labelXT";
            this.labelXT.Size = new System.Drawing.Size(27, 15);
            this.labelXT.TabIndex = 15;
            this.labelXT.Text = "x to";
            // 
            // Point2YTxt
            // 
            this.Point2YTxt.Location = new System.Drawing.Point(233, 95);
            this.Point2YTxt.Name = "Point2YTxt";
            this.Point2YTxt.Size = new System.Drawing.Size(100, 23);
            this.Point2YTxt.TabIndex = 14;
            this.Point2YTxt.Text = "44";
            // 
            // Point2XTxt
            // 
            this.Point2XTxt.Location = new System.Drawing.Point(58, 87);
            this.Point2XTxt.Name = "Point2XTxt";
            this.Point2XTxt.Size = new System.Drawing.Size(100, 23);
            this.Point2XTxt.TabIndex = 13;
            this.Point2XTxt.Text = "242242";
            // 
            // labelYF
            // 
            this.labelYF.AutoSize = true;
            this.labelYF.Location = new System.Drawing.Point(185, 50);
            this.labelYF.Name = "labelYF";
            this.labelYF.Size = new System.Drawing.Size(42, 15);
            this.labelYF.TabIndex = 12;
            this.labelYF.Text = "y from";
            this.labelYF.Click += new System.EventHandler(this.label2_Click);
            // 
            // Point1YTxt
            // 
            this.Point1YTxt.Location = new System.Drawing.Point(233, 47);
            this.Point1YTxt.Name = "Point1YTxt";
            this.Point1YTxt.Size = new System.Drawing.Size(100, 23);
            this.Point1YTxt.TabIndex = 11;
            this.Point1YTxt.Text = "2";
            // 
            // labelXF
            // 
            this.labelXF.AutoSize = true;
            this.labelXF.Location = new System.Drawing.Point(3, 47);
            this.labelXF.Name = "labelXF";
            this.labelXF.Size = new System.Drawing.Size(42, 15);
            this.labelXF.TabIndex = 10;
            this.labelXF.Text = "x from";
            // 
            // Point1XTxt
            // 
            this.Point1XTxt.Location = new System.Drawing.Point(58, 47);
            this.Point1XTxt.Name = "Point1XTxt";
            this.Point1XTxt.Size = new System.Drawing.Size(100, 23);
            this.Point1XTxt.TabIndex = 9;
            this.Point1XTxt.Text = "2";
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(3, 142);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(39, 15);
            this.Radius.TabIndex = 17;
            this.Radius.Text = "radius";
            this.Radius.Click += new System.EventHandler(this.Radius_Click);
            // 
            // RadiusTxt
            // 
            this.RadiusTxt.Location = new System.Drawing.Point(58, 142);
            this.RadiusTxt.Name = "RadiusTxt";
            this.RadiusTxt.Size = new System.Drawing.Size(100, 23);
            this.RadiusTxt.TabIndex = 18;
            // 
            // ShapeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadiusTxt);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.labelYT);
            this.Controls.Add(this.labelXT);
            this.Controls.Add(this.Point2YTxt);
            this.Controls.Add(this.Point2XTxt);
            this.Controls.Add(this.labelYF);
            this.Controls.Add(this.Point1YTxt);
            this.Controls.Add(this.labelXF);
            this.Controls.Add(this.Point1XTxt);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.ShapeKindCb);
            this.Name = "ShapeSelector";
            this.Size = new System.Drawing.Size(335, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ShapeKindCb;
        private Button drawBtn;
        private Label labelYT;
        private Label labelXT;
        private TextBox Point2YTxt;
        private TextBox Point2XTxt;
        private Label labelYF;
        private TextBox Point1YTxt;
        private Label labelXF;
        private TextBox Point1XTxt;
        private Label Radius;
        private TextBox RadiusTxt;
    }
}
