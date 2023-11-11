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
            this.label4 = new System.Windows.Forms.Label();
            this.xq = new System.Windows.Forms.Label();
            this.Point2YTxt = new System.Windows.Forms.TextBox();
            this.Point2XTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Point1YTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Point1XTxt = new System.Windows.Forms.TextBox();
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
            this.drawBtn.Location = new System.Drawing.Point(4, 145);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 23);
            this.drawBtn.TabIndex = 1;
            this.drawBtn.Text = "draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.DrawClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "y to";
            // 
            // xq
            // 
            this.xq.AutoSize = true;
            this.xq.Location = new System.Drawing.Point(3, 95);
            this.xq.Name = "xq";
            this.xq.Size = new System.Drawing.Size(27, 15);
            this.xq.TabIndex = 15;
            this.xq.Text = "x to";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "y from";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Point1YTxt
            // 
            this.Point1YTxt.Location = new System.Drawing.Point(233, 47);
            this.Point1YTxt.Name = "Point1YTxt";
            this.Point1YTxt.Size = new System.Drawing.Size(100, 23);
            this.Point1YTxt.TabIndex = 11;
            this.Point1YTxt.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "x from";
            // 
            // Point1XTxt
            // 
            this.Point1XTxt.Location = new System.Drawing.Point(58, 47);
            this.Point1XTxt.Name = "Point1XTxt";
            this.Point1XTxt.Size = new System.Drawing.Size(100, 23);
            this.Point1XTxt.TabIndex = 9;
            this.Point1XTxt.Text = "2";
            // 
            // ShapeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xq);
            this.Controls.Add(this.Point2YTxt);
            this.Controls.Add(this.Point2XTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Point1YTxt);
            this.Controls.Add(this.label1);
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
        private Label label4;
        private Label xq;
        private TextBox Point2YTxt;
        private TextBox Point2XTxt;
        private Label label2;
        private TextBox Point1YTxt;
        private Label label1;
        private TextBox Point1XTxt;
    }
}
