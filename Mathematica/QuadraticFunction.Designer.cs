namespace Mathematica
{
  partial class QuadraticFunction
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
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      numericUpDown1 = new NumericUpDown();
      numericUpDown2 = new NumericUpDown();
      numericUpDown3 = new NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(48, 68);
      label1.Name = "label1";
      label1.Size = new Size(13, 15);
      label1.TabIndex = 0;
      label1.Text = "a";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(48, 108);
      label2.Name = "label2";
      label2.Size = new Size(14, 15);
      label2.TabIndex = 1;
      label2.Text = "b";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(48, 156);
      label3.Name = "label3";
      label3.Size = new Size(13, 15);
      label3.TabIndex = 2;
      label3.Text = "c";
      // 
      // numericUpDown1
      // 
      numericUpDown1.Location = new Point(105, 60);
      numericUpDown1.Name = "numericUpDown1";
      numericUpDown1.Size = new Size(120, 23);
      numericUpDown1.TabIndex = 3;
      // 
      // numericUpDown2
      // 
      numericUpDown2.Location = new Point(105, 106);
      numericUpDown2.Name = "numericUpDown2";
      numericUpDown2.Size = new Size(120, 23);
      numericUpDown2.TabIndex = 4;
      // 
      // numericUpDown3
      // 
      numericUpDown3.Location = new Point(105, 148);
      numericUpDown3.Name = "numericUpDown3";
      numericUpDown3.Size = new Size(120, 23);
      numericUpDown3.TabIndex = 5;
      // 
      // QuadraticFunction
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(numericUpDown3);
      Controls.Add(numericUpDown2);
      Controls.Add(numericUpDown1);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "QuadraticFunction";
      Size = new Size(431, 425);
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown3;
  }
}
