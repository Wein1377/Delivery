
namespace WindowsFormsApp8
{
  partial class Register
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Username = new System.Windows.Forms.TextBox();
      this.reg = new System.Windows.Forms.Button();
      this.passField = new System.Windows.Forms.TextBox();
      this.logField = new System.Windows.Forms.TextBox();
      this.closeButton = new System.Windows.Forms.Label();
      this.address_field = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources._360_F_110152388_1x3oP8JvC7FaD2qtSLVcP0tMIlKZTUVK;
      this.pictureBox1.Location = new System.Drawing.Point(230, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(340, 173);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.address_field);
      this.groupBox1.Controls.Add(this.Username);
      this.groupBox1.Controls.Add(this.reg);
      this.groupBox1.Controls.Add(this.passField);
      this.groupBox1.Controls.Add(this.logField);
      this.groupBox1.Location = new System.Drawing.Point(230, 191);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(340, 247);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      // 
      // Username
      // 
      this.Username.Location = new System.Drawing.Point(33, 85);
      this.Username.Name = "Username";
      this.Username.Size = new System.Drawing.Size(268, 20);
      this.Username.TabIndex = 6;
      this.Username.Enter += new System.EventHandler(this.Username_Enter);
      this.Username.Leave += new System.EventHandler(this.Username_Leave);
      // 
      // reg
      // 
      this.reg.Location = new System.Drawing.Point(33, 181);
      this.reg.Name = "reg";
      this.reg.Size = new System.Drawing.Size(268, 23);
      this.reg.TabIndex = 3;
      this.reg.Text = "Регистрация";
      this.reg.UseVisualStyleBackColor = true;
      this.reg.Click += new System.EventHandler(this.reg_Click);
      // 
      // passField
      // 
      this.passField.Location = new System.Drawing.Point(33, 155);
      this.passField.Name = "passField";
      this.passField.Size = new System.Drawing.Size(268, 20);
      this.passField.TabIndex = 1;
      this.passField.Enter += new System.EventHandler(this.passField_Enter);
      this.passField.Leave += new System.EventHandler(this.passField_Leave);
      // 
      // logField
      // 
      this.logField.Location = new System.Drawing.Point(33, 46);
      this.logField.Name = "logField";
      this.logField.Size = new System.Drawing.Size(268, 20);
      this.logField.TabIndex = 0;
      this.logField.Enter += new System.EventHandler(this.logField_Enter);
      this.logField.Leave += new System.EventHandler(this.logField_Leave);
      // 
      // closeButton
      // 
      this.closeButton.AutoSize = true;
      this.closeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.closeButton.Location = new System.Drawing.Point(853, 12);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(16, 15);
      this.closeButton.TabIndex = 6;
      this.closeButton.Text = "X";
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // address_field
      // 
      this.address_field.Location = new System.Drawing.Point(33, 120);
      this.address_field.Name = "address_field";
      this.address_field.Size = new System.Drawing.Size(268, 20);
      this.address_field.TabIndex = 7;
      this.address_field.Enter += new System.EventHandler(this.address_field_Enter);
      this.address_field.Leave += new System.EventHandler(this.address_field_Leave);
      // 
      // Register
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(880, 492);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Register";
      this.Text = "Register";
      this.Load += new System.EventHandler(this.Register_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button reg;
    private System.Windows.Forms.TextBox passField;
    private System.Windows.Forms.TextBox logField;
    private System.Windows.Forms.TextBox Username;
    private System.Windows.Forms.Label closeButton;
    private System.Windows.Forms.TextBox address_field;
  }
}