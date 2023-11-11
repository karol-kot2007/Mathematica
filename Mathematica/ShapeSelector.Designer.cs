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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.xq = new System.Windows.Forms.Label();
            this.Yto = new System.Windows.Forms.TextBox();
            this.Xto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYfrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxXFrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "ShapeType ";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
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
            // Yto
            // 
            this.Yto.Location = new System.Drawing.Point(233, 95);
            this.Yto.Name = "Yto";
            this.Yto.Size = new System.Drawing.Size(100, 23);
            this.Yto.TabIndex = 14;
            this.Yto.Text = "44";
            // 
            // Xto
            // 
            this.Xto.Location = new System.Drawing.Point(58, 87);
            this.Xto.Name = "Xto";
            this.Xto.Size = new System.Drawing.Size(100, 23);
            this.Xto.TabIndex = 13;
            this.Xto.Text = "242242";
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
            // textBoxYfrom
            // 
            this.textBoxYfrom.Location = new System.Drawing.Point(233, 47);
            this.textBoxYfrom.Name = "textBoxYfrom";
            this.textBoxYfrom.Size = new System.Drawing.Size(100, 23);
            this.textBoxYfrom.TabIndex = 11;
            this.textBoxYfrom.Text = "2";
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
            // textBoxXFrom
            // 
            this.textBoxXFrom.Location = new System.Drawing.Point(58, 47);
            this.textBoxXFrom.Name = "textBoxXFrom";
            this.textBoxXFrom.Size = new System.Drawing.Size(100, 23);
            this.textBoxXFrom.TabIndex = 9;
            this.textBoxXFrom.Text = "2";
            // 
            // ShapeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xq);
            this.Controls.Add(this.Yto);
            this.Controls.Add(this.Xto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYfrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxXFrom);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.comboBox1);
            this.Name = "ShapeSelector";
            this.Size = new System.Drawing.Size(335, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button drawBtn;
        private Label label4;
        private Label xq;
        private TextBox Yto;
        private TextBox Xto;
        private Label label2;
        private TextBox textBoxYfrom;
        private Label label1;
        private TextBox textBoxXFrom;
    }
}
