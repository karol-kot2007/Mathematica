namespace Mathematica
{
  partial class LinearFunction
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
      numericUpDown1 = new NumericUpDown();
      numericUpDown2 = new NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(63, 56);
      label1.Name = "label1";
      label1.Size = new Size(13, 15);
      label1.TabIndex = 0;
      label1.Text = "a";
      label1.Click += label1_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(62, 88);
      label2.Name = "label2";
      label2.Size = new Size(14, 15);
      label2.TabIndex = 1;
      label2.Text = "b";
      // 
      // numericUpDown1
      // 
      numericUpDown1.Location = new Point(104, 48);
      numericUpDown1.Name = "numericUpDown1";
      numericUpDown1.Size = new Size(120, 23);
      numericUpDown1.TabIndex = 5;
      // 
      // numericUpDown2
      // 
      numericUpDown2.Location = new Point(104, 88);
      numericUpDown2.Name = "numericUpDown2";
      numericUpDown2.Size = new Size(120, 23);
      numericUpDown2.TabIndex = 6;
      // 
      // LinearFunction
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(numericUpDown2);
      Controls.Add(numericUpDown1);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "LinearFunction";
      Size = new Size(433, 299);
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
  }
}
