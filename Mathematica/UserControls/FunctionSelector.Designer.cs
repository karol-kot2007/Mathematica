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
      ApplyButton = new Button();
      linearFunction = new LinearFunction();
      quadraticFunction = new QuadraticFunction();
      tabControl1 = new TabControl();
      tabPage1 = new TabPage();
      tabPage2 = new TabPage();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      tabPage2.SuspendLayout();
      SuspendLayout();
      // 
      // comboBox1
      // 
      comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      comboBox1.FormattingEnabled = true;
      comboBox1.Items.AddRange(new object[] { "Linear function", "Quadratic function" });
      comboBox1.Location = new Point(43, 49);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(150, 21);
      comboBox1.TabIndex = 0;
      comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // ApplyButton
      // 
      ApplyButton.Location = new Point(43, 131);
      ApplyButton.Name = "ApplyButton";
      ApplyButton.Size = new Size(75, 23);
      ApplyButton.TabIndex = 1;
      ApplyButton.Text = "apply";
      ApplyButton.UseVisualStyleBackColor = true;
      ApplyButton.Click += ApplyButton_Click;
      // 
      // linearFunction
      // 
      linearFunction.AccessibleName = "linear_fun";
      linearFunction.Location = new Point(51, 29);
      linearFunction.Name = "linearFunction";
      linearFunction.point_a = 0;
      linearFunction.point_b = 0;
      linearFunction.Size = new Size(240, 382);
      linearFunction.TabIndex = 2;
      linearFunction.Load += this.linearFunction1_Load;
      // 
      // quadraticFunction
      // 
      quadraticFunction.AccessibleName = "quadra_fun";
      quadraticFunction.Location = new Point(26, 16);
      quadraticFunction.Name = "quadraticFunction";
      quadraticFunction.Size = new Size(239, 355);
      quadraticFunction.TabIndex = 3;
      quadraticFunction.Load += quadraticFunction1_Load;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Location = new Point(232, 49);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(302, 497);
      tabControl1.TabIndex = 4;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(linearFunction);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(294, 469);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "tabPage1";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      tabPage2.Controls.Add(quadraticFunction);
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(294, 469);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "tabPage2";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // FunctionSelector
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(tabControl1);
      Controls.Add(ApplyButton);
      Controls.Add(comboBox1);
      Name = "FunctionSelector";
      Size = new Size(549, 697);
      Load += FunctionSelector_Load;
      tabControl1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      tabPage2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private ComboBox comboBox1;
    private Button ApplyButton;
    private LinearFunction linearFunction;
    private QuadraticFunction quadraticFunction;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
  }
}
