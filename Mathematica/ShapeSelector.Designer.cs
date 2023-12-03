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
            this.labelY2 = new System.Windows.Forms.Label();
            this.Point2YTxt = new System.Windows.Forms.TextBox();
            this.Point2XTxt = new System.Windows.Forms.TextBox();
            this.labelY1 = new System.Windows.Forms.Label();
            this.Point1YTxt = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.Point1XTxt = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.Label();
            this.RadiusTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Point3XTxt = new System.Windows.Forms.TextBox();
            this.Point3YTxt = new System.Windows.Forms.TextBox();
            this.labelY3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ShapeKindCb
            // 
            this.ShapeKindCb.AccessibleName = "ShapeType ";
            this.ShapeKindCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeKindCb.FormattingEnabled = true;
            this.ShapeKindCb.Items.AddRange(new object[] {
            "lines",
            "circle",
            "triangle"});
            this.ShapeKindCb.Location = new System.Drawing.Point(80, 0);
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
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(210, 60);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(16, 15);
            this.labelY2.TabIndex = 16;
            this.labelY2.Text = "y ";
            // 
            // Point2YTxt
            // 
            this.Point2YTxt.Location = new System.Drawing.Point(232, 57);
            this.Point2YTxt.Name = "Point2YTxt";
            this.Point2YTxt.Size = new System.Drawing.Size(49, 23);
            this.Point2YTxt.TabIndex = 14;
            this.Point2YTxt.Text = "44";
            // 
            // Point2XTxt
            // 
            this.Point2XTxt.Location = new System.Drawing.Point(80, 57);
            this.Point2XTxt.Name = "Point2XTxt";
            this.Point2XTxt.Size = new System.Drawing.Size(41, 23);
            this.Point2XTxt.TabIndex = 13;
            this.Point2XTxt.Text = "100";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(210, 29);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(16, 15);
            this.labelY1.TabIndex = 12;
            this.labelY1.Text = "y ";
            this.labelY1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Point1YTxt
            // 
            this.Point1YTxt.Location = new System.Drawing.Point(232, 29);
            this.Point1YTxt.Name = "Point1YTxt";
            this.Point1YTxt.Size = new System.Drawing.Size(49, 23);
            this.Point1YTxt.TabIndex = 11;
            this.Point1YTxt.Text = "2";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(58, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(16, 15);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "x ";
            // 
            // Point1XTxt
            // 
            this.Point1XTxt.Location = new System.Drawing.Point(80, 29);
            this.Point1XTxt.Name = "Point1XTxt";
            this.Point1XTxt.Size = new System.Drawing.Size(41, 23);
            this.Point1XTxt.TabIndex = 9;
            this.Point1XTxt.Text = "2";
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(3, 152);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(39, 15);
            this.Radius.TabIndex = 17;
            this.Radius.Text = "radius";
            this.Radius.Click += new System.EventHandler(this.Radius_Click);
            // 
            // RadiusTxt
            // 
            this.RadiusTxt.Location = new System.Drawing.Point(58, 152);
            this.RadiusTxt.Name = "RadiusTxt";
            this.RadiusTxt.Size = new System.Drawing.Size(100, 23);
            this.RadiusTxt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Point 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Point 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Point 3";
            // 
            // Point3XTxt
            // 
            this.Point3XTxt.Location = new System.Drawing.Point(80, 83);
            this.Point3XTxt.Name = "Point3XTxt";
            this.Point3XTxt.Size = new System.Drawing.Size(41, 23);
            this.Point3XTxt.TabIndex = 24;
            this.Point3XTxt.Text = "50";
            // 
            // Point3YTxt
            // 
            this.Point3YTxt.Location = new System.Drawing.Point(232, 86);
            this.Point3YTxt.Name = "Point3YTxt";
            this.Point3YTxt.Size = new System.Drawing.Size(49, 23);
            this.Point3YTxt.TabIndex = 26;
            this.Point3YTxt.Text = "22";
            // 
            // labelY3
            // 
            this.labelY3.AutoSize = true;
            this.labelY3.Location = new System.Drawing.Point(210, 89);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(13, 15);
            this.labelY3.TabIndex = 28;
            this.labelY3.Text = "y";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(58, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(16, 15);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "x ";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(58, 83);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(16, 15);
            this.labelX3.TabIndex = 30;
            this.labelX3.Text = "x ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "color";
            // 
            // ColorCb
            // 
            this.ColorCb.FormattingEnabled = true;
            this.ColorCb.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.ColorCb.Location = new System.Drawing.Point(58, 201);
            this.ColorCb.Name = "ColorCb";
            this.ColorCb.Size = new System.Drawing.Size(74, 23);
            this.ColorCb.TabIndex = 32;
            this.ColorCb.SelectedIndexChanged += new System.EventHandler(this.ColorCb_SelectedIndexChanged);
            // 
            // ShapeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.Point3YTxt);
            this.Controls.Add(this.Point3XTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadiusTxt);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.Point2YTxt);
            this.Controls.Add(this.Point2XTxt);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.Point1YTxt);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.Point1XTxt);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.ShapeKindCb);
            this.Name = "ShapeSelector";
            this.Size = new System.Drawing.Size(335, 362);
            this.Load += new System.EventHandler(this.ShapeSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ShapeKindCb;
        private Button drawBtn;
        private Label labelY2;
        private TextBox Point2YTxt;
        private TextBox Point2XTxt;
        private Label labelY1;
        private TextBox Point1YTxt;
        private Label labelX1;
        private TextBox Point1XTxt;
        private Label Radius;
        private TextBox RadiusTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Point3XTxt;
        private TextBox Point3YTxt;
        private Label labelY3;
        private Label labelX2;
        private Label labelX3;
        private Label label4;
        private ComboBox ColorCb;
    }
}
