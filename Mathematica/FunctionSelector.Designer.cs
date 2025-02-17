﻿namespace Mathematica
{
  partial class FunctionSelector
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
      comboBox1 = new ComboBox();
      button1 = new Button();
      linearFunction1 = new LinearFunction();
      quadraticFunction1 = new QuadraticFunction();
      SuspendLayout();
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Items.AddRange(new object[] { "Linear function", "Quadratic function" });
      comboBox1.Location = new Point(43, 49);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(121, 23);
      comboBox1.TabIndex = 0;
      comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // button1
      // 
      button1.Location = new Point(43, 129);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 1;
      button1.Text = "apply";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // linearFunction1
      // 
      linearFunction1.Location = new Point(173, 0);
      linearFunction1.Name = "linearFunction1";
      linearFunction1.Size = new Size(259, 299);
      linearFunction1.TabIndex = 2;
      linearFunction1.Load += linearFunction1_Load;
      // 
      // quadraticFunction1
      // 
      quadraticFunction1.Location = new Point(464, 0);
      quadraticFunction1.Name = "quadraticFunction1";
      quadraticFunction1.Size = new Size(431, 425);
      quadraticFunction1.TabIndex = 3;
      quadraticFunction1.Load += quadraticFunction1_Load;
      // 
      // FunctionSelector
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(quadraticFunction1);
      Controls.Add(linearFunction1);
      Controls.Add(button1);
      Controls.Add(comboBox1);
      Name = "FunctionSelector";
      Size = new Size(919, 697);
      Load += FunctionSelector_Load;
      ResumeLayout(false);
    }

    #endregion

    private ComboBox comboBox1;
    private Button button1;
    private LinearFunction linearFunction1;
    private QuadraticFunction quadraticFunction1;
  }
}
