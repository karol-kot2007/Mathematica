namespace Mathematica
{
  partial class ShapeSelector
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
      ShapeKindCb = new ComboBox();
      drawBtn = new Button();
      labelY2 = new Label();
      Point2YTxt = new TextBox();
      Point2XTxt = new TextBox();
      labelY1 = new Label();
      Point1YTxt = new TextBox();
      labelX1 = new Label();
      Point1XTxt = new TextBox();
      Radius = new Label();
      RadiusTxt = new TextBox();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      Point3XTxt = new TextBox();
      Point3YTxt = new TextBox();
      labelY3 = new Label();
      labelX2 = new Label();
      labelX3 = new Label();
      label4 = new Label();
      ColorCb = new ComboBox();
      SuspendLayout();
      // 
      // ShapeKindCb
      // 
      ShapeKindCb.AccessibleName = "ShapeType ";
      ShapeKindCb.DropDownStyle = ComboBoxStyle.DropDownList;
      ShapeKindCb.FormattingEnabled = true;
      ShapeKindCb.Items.AddRange(new object[] { "lines", "circle", "triangle" });
      ShapeKindCb.Location = new Point(80, 0);
      ShapeKindCb.Name = "ShapeKindCb";
      ShapeKindCb.Size = new Size(121, 23);
      ShapeKindCb.TabIndex = 0;
      ShapeKindCb.SelectedIndexChanged += ShapeKind_SelectedIndexChanged;
      // 
      // drawBtn
      // 
      drawBtn.Location = new Point(3, 230);
      drawBtn.Name = "drawBtn";
      drawBtn.Size = new Size(75, 23);
      drawBtn.TabIndex = 1;
      drawBtn.Text = "draw";
      drawBtn.UseVisualStyleBackColor = true;
      drawBtn.Click += DrawClick;
      // 
      // labelY2
      // 
      labelY2.AutoSize = true;
      labelY2.Location = new Point(210, 60);
      labelY2.Name = "labelY2";
      labelY2.Size = new Size(16, 15);
      labelY2.TabIndex = 16;
      labelY2.Text = "y ";
      // 
      // Point2YTxt
      // 
      Point2YTxt.Location = new Point(232, 57);
      Point2YTxt.Name = "Point2YTxt";
      Point2YTxt.Size = new Size(49, 23);
      Point2YTxt.TabIndex = 14;
      Point2YTxt.Text = "44";
      Point2YTxt.TextAlign = HorizontalAlignment.Center;
      // 
      // Point2XTxt
      // 
      Point2XTxt.Location = new Point(80, 57);
      Point2XTxt.Name = "Point2XTxt";
      Point2XTxt.Size = new Size(41, 23);
      Point2XTxt.TabIndex = 13;
      Point2XTxt.Text = "100";
      Point2XTxt.TextAlign = HorizontalAlignment.Center;
      // 
      // labelY1
      // 
      labelY1.AutoSize = true;
      labelY1.Location = new Point(210, 29);
      labelY1.Name = "labelY1";
      labelY1.Size = new Size(16, 15);
      labelY1.TabIndex = 12;
      labelY1.Text = "y ";
      labelY1.Click += label2_Click;
      // 
      // Point1YTxt
      // 
      Point1YTxt.Location = new Point(232, 29);
      Point1YTxt.Name = "Point1YTxt";
      Point1YTxt.Size = new Size(49, 23);
      Point1YTxt.TabIndex = 11;
      Point1YTxt.Text = "2";
      Point1YTxt.TextAlign = HorizontalAlignment.Center;
      // 
      // labelX1
      // 
      labelX1.AutoSize = true;
      labelX1.Location = new Point(58, 29);
      labelX1.Name = "labelX1";
      labelX1.Size = new Size(16, 15);
      labelX1.TabIndex = 10;
      labelX1.Text = "x ";
      // 
      // Point1XTxt
      // 
      Point1XTxt.Location = new Point(80, 29);
      Point1XTxt.Name = "Point1XTxt";
      Point1XTxt.Size = new Size(41, 23);
      Point1XTxt.TabIndex = 9;
      Point1XTxt.Text = "23";
      Point1XTxt.TextAlign = HorizontalAlignment.Center;
      // 
      // Radius
      // 
      Radius.AutoSize = true;
      Radius.Location = new Point(3, 152);
      Radius.Name = "Radius";
      Radius.Size = new Size(39, 15);
      Radius.TabIndex = 17;
      Radius.Text = "radius";
      Radius.Click += Radius_Click;
      // 
      // RadiusTxt
      // 
      RadiusTxt.Location = new Point(58, 152);
      RadiusTxt.Name = "RadiusTxt";
      RadiusTxt.Size = new Size(100, 23);
      RadiusTxt.TabIndex = 18;
      RadiusTxt.TextAlign = HorizontalAlignment.Center;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(0, 29);
      label1.Name = "label1";
      label1.Size = new Size(44, 15);
      label1.TabIndex = 19;
      label1.Text = "Point 1";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(3, 62);
      label2.Name = "label2";
      label2.Size = new Size(44, 15);
      label2.TabIndex = 20;
      label2.Text = "Point 2";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(3, 83);
      label3.Name = "label3";
      label3.Size = new Size(44, 15);
      label3.TabIndex = 21;
      label3.Text = "Point 3";
      // 
      // Point3XTxt
      // 
      Point3XTxt.Location = new Point(80, 83);
      Point3XTxt.Name = "Point3XTxt";
      Point3XTxt.Size = new Size(41, 23);
      Point3XTxt.TabIndex = 24;
      Point3XTxt.Text = "2";
      Point3XTxt.TextAlign = HorizontalAlignment.Center;
      // 
      // Point3YTxt
      // 
      Point3YTxt.Location = new Point(232, 86);
      Point3YTxt.Name = "Point3YTxt";
      Point3YTxt.Size = new Size(49, 23);
      Point3YTxt.TabIndex = 26;
      Point3YTxt.Text = "22";
      Point3YTxt.TextAlign = HorizontalAlignment.Center;
      // 
      // labelY3
      // 
      labelY3.AutoSize = true;
      labelY3.Location = new Point(210, 89);
      labelY3.Name = "labelY3";
      labelY3.Size = new Size(13, 15);
      labelY3.TabIndex = 28;
      labelY3.Text = "y";
      // 
      // labelX2
      // 
      labelX2.AutoSize = true;
      labelX2.Location = new Point(58, 60);
      labelX2.Name = "labelX2";
      labelX2.Size = new Size(16, 15);
      labelX2.TabIndex = 29;
      labelX2.Text = "x ";
      // 
      // labelX3
      // 
      labelX3.AutoSize = true;
      labelX3.Location = new Point(58, 83);
      labelX3.Name = "labelX3";
      labelX3.Size = new Size(16, 15);
      labelX3.TabIndex = 30;
      labelX3.Text = "x ";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(4, 201);
      label4.Name = "label4";
      label4.Size = new Size(34, 15);
      label4.TabIndex = 31;
      label4.Text = "color";
      // 
      // ColorCb
      // 
      ColorCb.FormattingEnabled = true;
      ColorCb.Items.AddRange(new object[] { "Red", "Blue", "Green" });
      ColorCb.Location = new Point(58, 201);
      ColorCb.Name = "ColorCb";
      ColorCb.Size = new Size(74, 23);
      ColorCb.TabIndex = 32;
      ColorCb.SelectedIndexChanged += ColorCb_SelectedIndexChanged;
      // 
      // ShapeSelector
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(ColorCb);
      Controls.Add(label4);
      Controls.Add(labelX3);
      Controls.Add(labelX2);
      Controls.Add(labelY3);
      Controls.Add(Point3YTxt);
      Controls.Add(Point3XTxt);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(RadiusTxt);
      Controls.Add(Radius);
      Controls.Add(labelY2);
      Controls.Add(Point2YTxt);
      Controls.Add(Point2XTxt);
      Controls.Add(labelY1);
      Controls.Add(Point1YTxt);
      Controls.Add(labelX1);
      Controls.Add(Point1XTxt);
      Controls.Add(drawBtn);
      Controls.Add(ShapeKindCb);
      Name = "ShapeSelector";
      Size = new Size(335, 362);
      Load += ShapeSelector_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private ComboBox ShapeKindCb;
    private Button drawBtn;
    private Label labelY2;
    private TextBox Point2YTxt;
    private TextBox Point2XTxt;
    private Label labelY1;
    private TextBox Point1YTxt;
    private Label labelX1;
    private TextBox Point1XTxt;
    private Label Radius;
    private TextBox RadiusTxt;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox Point3XTxt;
    private TextBox Point3YTxt;
    private Label labelY3;
    private Label labelX2;
    private Label labelX3;
    private Label label4;
    private ComboBox ColorCb;
  }
}
