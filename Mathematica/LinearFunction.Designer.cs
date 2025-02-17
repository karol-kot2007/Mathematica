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
      textBox1 = new TextBox();
      textBox2 = new TextBox();
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
      // textBox1
      // 
      textBox1.Location = new Point(101, 53);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(100, 23);
      textBox1.TabIndex = 3;
      textBox1.TextAlign = HorizontalAlignment.Center;
      // 
      // textBox2
      // 
      textBox2.Location = new Point(101, 85);
      textBox2.Name = "textBox2";
      textBox2.Size = new Size(100, 23);
      textBox2.TabIndex = 4;
      textBox2.TextAlign = HorizontalAlignment.Center;
      // 
      // LinearFunction
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(textBox2);
      Controls.Add(textBox1);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "LinearFunction";
      Size = new Size(433, 299);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
  }
}
