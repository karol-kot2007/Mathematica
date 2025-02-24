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
      a_linear = new NumericUpDown();
      b_linear = new NumericUpDown();
      result_label_linear = new Label();
      ((System.ComponentModel.ISupportInitialize)a_linear).BeginInit();
      ((System.ComponentModel.ISupportInitialize)b_linear).BeginInit();
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
      // a_linear
      // 
      a_linear.Location = new Point(104, 48);
      a_linear.Name = "a_linear";
      a_linear.Size = new Size(120, 23);
      a_linear.TabIndex = 5;
      a_linear.ValueChanged += a_ValueChanged;
      // 
      // b_linear
      // 
      b_linear.Location = new Point(104, 87);
      b_linear.Name = "b_linear";
      b_linear.Size = new Size(120, 23);
      b_linear.TabIndex = 6;
      b_linear.ValueChanged += b_linear_ValueChanged;
      // 
      // result_label_linear
      // 
      result_label_linear.AutoSize = true;
      result_label_linear.Location = new Point(120, 131);
      result_label_linear.Name = "result_label_linear";
      result_label_linear.Size = new Size(0, 15);
      result_label_linear.TabIndex = 7;
      result_label_linear.Click += label3_Click;
      // 
      // LinearFunction
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(result_label_linear);
      Controls.Add(b_linear);
      Controls.Add(a_linear);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "LinearFunction";
      Size = new Size(433, 299);
      ((System.ComponentModel.ISupportInitialize)a_linear).EndInit();
      ((System.ComponentModel.ISupportInitialize)b_linear).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private NumericUpDown a_linear;
    private NumericUpDown b_linear;
    private Label result_label_linear;
  }
}
