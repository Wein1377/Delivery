
namespace WindowsFormsApp8
{
  partial class WhoAreYou
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.splitter2 = new System.Windows.Forms.Splitter();
      this.closeButton = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.Color.DimGray;
      this.splitter1.Location = new System.Drawing.Point(0, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(394, 450);
      this.splitter1.TabIndex = 0;
      this.splitter1.TabStop = false;
      this.splitter1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseDown);
      this.splitter1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseMove);
      // 
      // splitter2
      // 
      this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.splitter2.Location = new System.Drawing.Point(394, 0);
      this.splitter2.Name = "splitter2";
      this.splitter2.Size = new System.Drawing.Size(407, 450);
      this.splitter2.TabIndex = 1;
      this.splitter2.TabStop = false;
      this.splitter2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitter2_MouseDown);
      this.splitter2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitter2_MouseMove);
      // 
      // closeButton
      // 
      this.closeButton.AutoSize = true;
      this.closeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.closeButton.Location = new System.Drawing.Point(772, 9);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(16, 15);
      this.closeButton.TabIndex = 7;
      this.closeButton.Text = "X";
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.DimGray;
      this.label1.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(72, 176);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(258, 69);
      this.label1.TabIndex = 8;
      this.label1.Text = "Шоппер";
      this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
      this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label2.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(439, 176);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(334, 69);
      this.label2.TabIndex = 9;
      this.label2.Text = "Заказчик";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
      this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
      // 
      // WhoAreYou
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.splitter2);
      this.Controls.Add(this.splitter1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "WhoAreYou";
      this.Text = "WhoAreYou";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Splitter splitter2;
    private System.Windows.Forms.Label closeButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}