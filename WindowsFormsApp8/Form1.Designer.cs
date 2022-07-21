
namespace WindowsFormsApp8
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.reg = new System.Windows.Forms.Button();
      this.aut = new System.Windows.Forms.Button();
      this.passField = new System.Windows.Forms.TextBox();
      this.logField = new System.Windows.Forms.TextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.closeButton = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.reg);
      this.groupBox1.Controls.Add(this.aut);
      this.groupBox1.Controls.Add(this.passField);
      this.groupBox1.Controls.Add(this.logField);
      this.groupBox1.Location = new System.Drawing.Point(81, 191);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(340, 247);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // reg
      // 
      this.reg.Location = new System.Drawing.Point(33, 194);
      this.reg.Name = "reg";
      this.reg.Size = new System.Drawing.Size(268, 23);
      this.reg.TabIndex = 3;
      this.reg.Text = "Регистрация";
      this.reg.UseVisualStyleBackColor = true;
      this.reg.Click += new System.EventHandler(this.reg_Click);
      // 
      // aut
      // 
      this.aut.Location = new System.Drawing.Point(33, 147);
      this.aut.Name = "aut";
      this.aut.Size = new System.Drawing.Size(268, 23);
      this.aut.TabIndex = 2;
      this.aut.Text = "Авторизация";
      this.aut.UseVisualStyleBackColor = true;
      this.aut.Click += new System.EventHandler(this.aut_Click);
      // 
      // passField
      // 
      this.passField.Location = new System.Drawing.Point(33, 91);
      this.passField.Name = "passField";
      this.passField.Size = new System.Drawing.Size(268, 20);
      this.passField.TabIndex = 1;
      this.passField.Enter += new System.EventHandler(this.passField_Enter_1);
      this.passField.Leave += new System.EventHandler(this.passField_Leave_1);
      // 
      // logField
      // 
      this.logField.Location = new System.Drawing.Point(33, 46);
      this.logField.Name = "logField";
      this.logField.Size = new System.Drawing.Size(268, 20);
      this.logField.TabIndex = 0;
      this.logField.Enter += new System.EventHandler(this.logField_Enter_1);
      this.logField.Leave += new System.EventHandler(this.logField_Leave_1);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // closeButton
      // 
      this.closeButton.AutoSize = true;
      this.closeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.closeButton.Location = new System.Drawing.Point(504, 12);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(16, 15);
      this.closeButton.TabIndex = 4;
      this.closeButton.Text = "X";
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources._360_F_110152388_1x3oP8JvC7FaD2qtSLVcP0tMIlKZTUVK;
      this.pictureBox1.Location = new System.Drawing.Point(81, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(340, 173);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Silver;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "x";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(530, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button reg;
    private System.Windows.Forms.Button aut;
    private System.Windows.Forms.TextBox passField;
    private System.Windows.Forms.TextBox logField;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label closeButton;
    private System.Windows.Forms.Label label1;
  }
}

