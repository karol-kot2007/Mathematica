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
      a = new NumericUpDown();
      b = new NumericUpDown();
      c = new NumericUpDown();
      result_label_quadratic = new Label();
      ((System.ComponentModel.ISupportInitialize)a).BeginInit();
      ((System.ComponentModel.ISupportInitialize)b).BeginInit();
      ((System.ComponentModel.ISupportInitialize)c).BeginInit();
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
      a.AccessibleName = "nr_1";
      a.Location = new Point(105, 68);
      a.Name = "numericUpDown1";
      a.Size = new Size(120, 23);
      a.TabIndex = 3;
      a.Value = new decimal(new int[] { 1, 0, 0, 0 });
      a.ValueChanged += numericUpDown1_ValueChanged;
      // 
      // numericUpDown2
      // 
      b.AccessibleDescription = "nr_2";
      b.Location = new Point(105, 108);
      b.Name = "numericUpDown2";
      b.Size = new Size(120, 23);
      b.TabIndex = 4;
      // 
      // numericUpDown3
      // 
      c.AccessibleDescription = "nr_3";
      c.Location = new Point(105, 154);
      c.Name = "numericUpDown3";
      c.Size = new Size(120, 23);
      c.TabIndex = 5;
      c.Value = new decimal(new int[] { 3, 0, 0, 0 });
      c.ValueChanged += numericUpDown3_ValueChanged;
      // 
      // result_label_quadratic
      // 
      result_label_quadratic.AutoSize = true;
      result_label_quadratic.Location = new Point(105, 213);
      result_label_quadratic.Name = "result_label_quadratic";
      result_label_quadratic.Size = new Size(36, 15);
      result_label_quadratic.TabIndex = 6;
      result_label_quadratic.Text = "dfdfd";
      result_label_quadratic.Click += label4_Click;
      // 
      // QuadraticFunction
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(result_label_quadratic);
      Controls.Add(c);
      Controls.Add(b);
      Controls.Add(a);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "QuadraticFunction";
      Size = new Size(431, 425);
      Load += QuadraticFunction_Load;
      ((System.ComponentModel.ISupportInitialize)a).EndInit();
      ((System.ComponentModel.ISupportInitialize)b).EndInit();
      ((System.ComponentModel.ISupportInitialize)c).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private NumericUpDown a;
    private NumericUpDown b;
    private NumericUpDown c;
    private Label result_label_quadratic;
  }
}
