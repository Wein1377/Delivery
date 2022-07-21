
namespace WindowsFormsApp8
{
  partial class ChooseOrder
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Заказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Открыть = new System.Windows.Forms.DataGridViewButtonColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Заказ,
            this.Адрес,
            this.Открыть});
      this.dataGridView1.Location = new System.Drawing.Point(12, 22);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.Size = new System.Drawing.Size(1055, 484);
      this.dataGridView1.TabIndex = 0;
      // 
      // Заказ
      // 
      this.Заказ.HeaderText = "Заказ";
      this.Заказ.Name = "Заказ";
      // 
      // Адрес
      // 
      this.Адрес.HeaderText = "Адрес";
      this.Адрес.Name = "Адрес";
      // 
      // Открыть
      // 
      this.Открыть.HeaderText = "Открыть";
      this.Открыть.Name = "Открыть";
      // 
      // ChooseOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1111, 566);
      this.Controls.Add(this.dataGridView1);
      this.Name = "ChooseOrder";
      this.Text = "ChooseOrder";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Заказ;
    private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
    private System.Windows.Forms.DataGridViewButtonColumn Открыть;
  }
}