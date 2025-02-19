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
      a = new NumericUpDown();
      b = new NumericUpDown();
      result_label_linear = new Label();
      ((System.ComponentModel.ISupportInitialize)a).BeginInit();
      ((System.ComponentModel.ISupportInitialize)b).BeginInit();
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
      // a
      // 
      a.Location = new Point(104, 48);
      a.Name = "a";
      a.Size = new Size(120, 23);
      a.TabIndex = 5;
      a.Value = new decimal(new int[] { 44, 0, 0, 0 });
      a.ValueChanged += a_ValueChanged;
      // 
      // b
      // 
      b.Location = new Point(104, 88);
      b.Name = "b";
      b.Size = new Size(120, 23);
      b.TabIndex = 6;
      b.Value = new decimal(new int[] { 3, 0, 0, 0 });
      // 
      // result_label_linear
      // 
      result_label_linear.AutoSize = true;
      result_label_linear.Location = new Point(120, 131);
      result_label_linear.Name = "result_label_linear";
      result_label_linear.Size = new Size(38, 15);
      result_label_linear.TabIndex = 7;
      result_label_linear.Text = "label3";
      result_label_linear.Click += label3_Click;
      // 
      // LinearFunction
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(result_label_linear);
      Controls.Add(b);
      Controls.Add(a);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "LinearFunction";
      Size = new Size(433, 299);
      ((System.ComponentModel.ISupportInitialize)a).EndInit();
      ((System.ComponentModel.ISupportInitialize)b).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private NumericUpDown a;
    private NumericUpDown b;
    private Label result_label_linear;
  }
}
