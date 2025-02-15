namespace Mathematica
{
    partial class FunctionChartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.functionChart1 = new Mathematica.FunctionChart();
            this.SuspendLayout();
            // 
            // functionChart1
            // 
            this.functionChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functionChart1.ChartLineXLeft = new System.Drawing.Point(10, 400);
            this.functionChart1.ChartLineXRight = new System.Drawing.Point(500, 400);
            this.functionChart1.ChartLineYBottom = new System.Drawing.Point(10, 400);
            this.functionChart1.ChartLineYTop = new System.Drawing.Point(10, 10);
            this.functionChart1.Location = new System.Drawing.Point(1, 1);
            this.functionChart1.Name = "functionChart1";
            this.functionChart1.Size = new System.Drawing.Size(982, 674);
            this.functionChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 677);
            this.Controls.Add(this.functionChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FunctionChart functionChart1;
    }
}