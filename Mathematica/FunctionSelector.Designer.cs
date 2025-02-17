namespace Mathematica
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
      userControl11 = new UserControl1();
      SuspendLayout();
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Location = new Point(192, 57);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(121, 23);
      comboBox1.TabIndex = 0;
      comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // button1
      // 
      button1.Location = new Point(237, 143);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 1;
      button1.Text = "button1";
      button1.UseVisualStyleBackColor = true;
      // 
      // userControl11
      // 
      userControl11.Location = new Point(3, 143);
      userControl11.Name = "userControl11";
      userControl11.Size = new Size(150, 150);
      userControl11.TabIndex = 2;
      // 
      // FunctionSelector
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(userControl11);
      Controls.Add(button1);
      Controls.Add(comboBox1);
      Name = "FunctionSelector";
      Size = new Size(432, 471);
      Load += FunctionSelector_Load;
      ResumeLayout(false);
    }

    #endregion

    private ComboBox comboBox1;
    private Button button1;
    private UserControl1 userControl11;
  }
}
