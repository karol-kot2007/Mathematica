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
      functionChart1 = new FunctionChart();
      functionSelector1 = new FunctionSelector();
      SuspendLayout();
      // 
      // functionChart1
      // 
      functionChart1.BorderStyle = BorderStyle.FixedSingle;
      functionChart1.ChartLineXLeft = new Point(10, 400);
      functionChart1.ChartLineXRight = new Point(500, 400);
      functionChart1.ChartLineYBottom = new Point(10, 400);
      functionChart1.ChartLineYTop = new Point(10, 10);
      functionChart1.Location = new Point(1, 1);
      functionChart1.Name = "functionChart1";
      functionChart1.Size = new Size(982, 674);
      functionChart1.TabIndex = 0;
      // 
      // functionSelector1
      // 
      functionSelector1.FunType = null;
      functionSelector1.Location = new Point(989, 55);
      functionSelector1.Name = "functionSelector1";
      functionSelector1.Size = new Size(616, 332);
      functionSelector1.TabIndex = 1;
      functionSelector1.Load += functionSelector1_Load;
      // 
      // FunctionChartForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ActiveCaption;
      ClientSize = new Size(1602, 958);
      Controls.Add(functionSelector1);
      Controls.Add(functionChart1);
      Name = "FunctionChartForm";
      Text = "Form1";
      ResumeLayout(false);
    }

    #endregion

    private FunctionChart functionChart1;
    private FunctionSelector functionSelector1;
  }
}