
namespace WindowsFormsApp8
{
  partial class Adminpage
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
      this.add_button = new System.Windows.Forms.Button();
      this.address_groupBox = new System.Windows.Forms.GroupBox();
      this.address_textBox = new System.Windows.Forms.TextBox();
      this.name_groupBox = new System.Windows.Forms.GroupBox();
      this.name_textBox = new System.Windows.Forms.TextBox();
      this.shops = new System.Windows.Forms.DataGridView();
      this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Район = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Действие = new System.Windows.Forms.DataGridViewButtonColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.district_textbox = new System.Windows.Forms.TextBox();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.count_numericUpDown = new System.Windows.Forms.NumericUpDown();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.price_label = new System.Windows.Forms.Label();
      this.add_product_to_shop_button = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.shop_label = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.price_with_extra_charge_label = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.extra_charge_numericUpDown = new System.Windows.Forms.NumericUpDown();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.product_name_label = new System.Windows.Forms.Label();
      this.addProduct_button = new System.Windows.Forms.Button();
      this.productPrice__groupBox = new System.Windows.Forms.GroupBox();
      this.productPrice_textBox = new System.Windows.Forms.TextBox();
      this.productName_groupBox = new System.Windows.Forms.GroupBox();
      this.productName_textBox = new System.Windows.Forms.TextBox();
      this.products = new System.Windows.Forms.DataGridView();
      this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.product_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.price_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.action_product = new System.Windows.Forms.DataGridViewButtonColumn();
      this.closeButton = new System.Windows.Forms.Label();
      this.address_groupBox.SuspendLayout();
      this.name_groupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.shops)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).BeginInit();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.extra_charge_numericUpDown)).BeginInit();
      this.groupBox7.SuspendLayout();
      this.productPrice__groupBox.SuspendLayout();
      this.productName_groupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
      this.SuspendLayout();
      // 
      // add_button
      // 
      this.add_button.Location = new System.Drawing.Point(419, 26);
      this.add_button.Name = "add_button";
      this.add_button.Size = new System.Drawing.Size(114, 36);
      this.add_button.TabIndex = 8;
      this.add_button.Text = "Добавить";
      this.add_button.UseVisualStyleBackColor = true;
      this.add_button.Click += new System.EventHandler(this.add_button_Click_1);
      // 
      // address_groupBox
      // 
      this.address_groupBox.Controls.Add(this.address_textBox);
      this.address_groupBox.Location = new System.Drawing.Point(136, 12);
      this.address_groupBox.Name = "address_groupBox";
      this.address_groupBox.Size = new System.Drawing.Size(152, 40);
      this.address_groupBox.TabIndex = 7;
      this.address_groupBox.TabStop = false;
      this.address_groupBox.Text = "Адрес";
      // 
      // address_textBox
      // 
      this.address_textBox.Location = new System.Drawing.Point(6, 14);
      this.address_textBox.MaxLength = 60;
      this.address_textBox.Name = "address_textBox";
      this.address_textBox.Size = new System.Drawing.Size(133, 20);
      this.address_textBox.TabIndex = 5;
      // 
      // name_groupBox
      // 
      this.name_groupBox.Controls.Add(this.name_textBox);
      this.name_groupBox.Location = new System.Drawing.Point(12, 12);
      this.name_groupBox.Name = "name_groupBox";
      this.name_groupBox.Size = new System.Drawing.Size(118, 40);
      this.name_groupBox.TabIndex = 6;
      this.name_groupBox.TabStop = false;
      this.name_groupBox.Text = "Название магазина";
      // 
      // name_textBox
      // 
      this.name_textBox.Location = new System.Drawing.Point(6, 14);
      this.name_textBox.MaxLength = 30;
      this.name_textBox.Name = "name_textBox";
      this.name_textBox.Size = new System.Drawing.Size(106, 20);
      this.name_textBox.TabIndex = 1;
      // 
      // shops
      // 
      this.shops.AllowUserToAddRows = false;
      this.shops.AllowUserToDeleteRows = false;
      this.shops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.shops.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.shops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.shops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название,
            this.Адрес,
            this.Район,
            this.district,
            this.Действие});
      this.shops.Location = new System.Drawing.Point(12, 74);
      this.shops.MultiSelect = false;
      this.shops.Name = "shops";
      this.shops.ReadOnly = true;
      this.shops.RowHeadersVisible = false;
      this.shops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.shops.Size = new System.Drawing.Size(521, 294);
      this.shops.TabIndex = 5;
      this.shops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shops_CellContentClick_1);
      this.shops.SelectionChanged += new System.EventHandler(this.shops_SelectionChanged_1);
      // 
      // Название
      // 
      this.Название.HeaderText = "Id";
      this.Название.Name = "Название";
      this.Название.ReadOnly = true;
      this.Название.Width = 41;
      // 
      // Адрес
      // 
      this.Адрес.HeaderText = "Название";
      this.Адрес.Name = "Адрес";
      this.Адрес.ReadOnly = true;
      this.Адрес.Width = 82;
      // 
      // Район
      // 
      this.Район.HeaderText = "Адрес";
      this.Район.Name = "Район";
      this.Район.ReadOnly = true;
      this.Район.Width = 63;
      // 
      // district
      // 
      this.district.HeaderText = "Район";
      this.district.Name = "district";
      this.district.ReadOnly = true;
      this.district.Width = 63;
      // 
      // Действие
      // 
      this.Действие.HeaderText = "Действие";
      this.Действие.Name = "Действие";
      this.Действие.ReadOnly = true;
      this.Действие.Width = 63;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.district_textbox);
      this.groupBox1.Location = new System.Drawing.Point(294, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(106, 40);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Район";
      // 
      // district_textbox
      // 
      this.district_textbox.Location = new System.Drawing.Point(6, 14);
      this.district_textbox.MaxLength = 60;
      this.district_textbox.Name = "district_textbox";
      this.district_textbox.Size = new System.Drawing.Size(94, 20);
      this.district_textbox.TabIndex = 5;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.count_numericUpDown);
      this.groupBox6.Location = new System.Drawing.Point(610, 228);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(66, 50);
      this.groupBox6.TabIndex = 115;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Кол-во";
      // 
      // count_numericUpDown
      // 
      this.count_numericUpDown.Location = new System.Drawing.Point(6, 19);
      this.count_numericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.count_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.count_numericUpDown.Name = "count_numericUpDown";
      this.count_numericUpDown.Size = new System.Drawing.Size(54, 20);
      this.count_numericUpDown.TabIndex = 0;
      this.count_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.price_label);
      this.groupBox5.Location = new System.Drawing.Point(539, 172);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(137, 50);
      this.groupBox5.TabIndex = 114;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Цена";
      // 
      // price_label
      // 
      this.price_label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.price_label.Location = new System.Drawing.Point(3, 16);
      this.price_label.Name = "price_label";
      this.price_label.Size = new System.Drawing.Size(131, 31);
      this.price_label.TabIndex = 0;
      this.price_label.Text = "-";
      this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // add_product_to_shop_button
      // 
      this.add_product_to_shop_button.Enabled = false;
      this.add_product_to_shop_button.Location = new System.Drawing.Point(539, 340);
      this.add_product_to_shop_button.Name = "add_product_to_shop_button";
      this.add_product_to_shop_button.Size = new System.Drawing.Size(137, 23);
      this.add_product_to_shop_button.TabIndex = 113;
      this.add_product_to_shop_button.Text = "Добавить";
      this.add_product_to_shop_button.UseVisualStyleBackColor = true;
      this.add_product_to_shop_button.Click += new System.EventHandler(this.add_product_to_shop_button_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.shop_label);
      this.groupBox4.Location = new System.Drawing.Point(539, 116);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(137, 50);
      this.groupBox4.TabIndex = 112;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Магазин";
      // 
      // shop_label
      // 
      this.shop_label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.shop_label.Location = new System.Drawing.Point(3, 16);
      this.shop_label.Name = "shop_label";
      this.shop_label.Size = new System.Drawing.Size(131, 31);
      this.shop_label.TabIndex = 0;
      this.shop_label.Text = "-";
      this.shop_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.price_with_extra_charge_label);
      this.groupBox3.Location = new System.Drawing.Point(539, 284);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(137, 50);
      this.groupBox3.TabIndex = 111;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Итоговая цена";
      // 
      // price_with_extra_charge_label
      // 
      this.price_with_extra_charge_label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.price_with_extra_charge_label.Location = new System.Drawing.Point(3, 16);
      this.price_with_extra_charge_label.Name = "price_with_extra_charge_label";
      this.price_with_extra_charge_label.Size = new System.Drawing.Size(131, 31);
      this.price_with_extra_charge_label.TabIndex = 0;
      this.price_with_extra_charge_label.Text = "-";
      this.price_with_extra_charge_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.extra_charge_numericUpDown);
      this.groupBox2.Location = new System.Drawing.Point(539, 228);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(66, 50);
      this.groupBox2.TabIndex = 110;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Наценка";
      // 
      // extra_charge_numericUpDown
      // 
      this.extra_charge_numericUpDown.Location = new System.Drawing.Point(6, 19);
      this.extra_charge_numericUpDown.Name = "extra_charge_numericUpDown";
      this.extra_charge_numericUpDown.Size = new System.Drawing.Size(54, 20);
      this.extra_charge_numericUpDown.TabIndex = 0;
      this.extra_charge_numericUpDown.ValueChanged += new System.EventHandler(this.extra_charge_numericUpDown_ValueChanged_1);
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.product_name_label);
      this.groupBox7.Location = new System.Drawing.Point(539, 58);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(137, 50);
      this.groupBox7.TabIndex = 109;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Название товара";
      // 
      // product_name_label
      // 
      this.product_name_label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.product_name_label.Location = new System.Drawing.Point(3, 16);
      this.product_name_label.Name = "product_name_label";
      this.product_name_label.Size = new System.Drawing.Size(131, 31);
      this.product_name_label.TabIndex = 0;
      this.product_name_label.Text = "-";
      this.product_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // addProduct_button
      // 
      this.addProduct_button.Location = new System.Drawing.Point(982, 23);
      this.addProduct_button.Name = "addProduct_button";
      this.addProduct_button.Size = new System.Drawing.Size(79, 37);
      this.addProduct_button.TabIndex = 116;
      this.addProduct_button.Text = "Добавить";
      this.addProduct_button.UseVisualStyleBackColor = true;
      this.addProduct_button.Click += new System.EventHandler(this.addProduct_button_Click);
      // 
      // productPrice__groupBox
      // 
      this.productPrice__groupBox.Controls.Add(this.productPrice_textBox);
      this.productPrice__groupBox.Location = new System.Drawing.Point(863, 12);
      this.productPrice__groupBox.Name = "productPrice__groupBox";
      this.productPrice__groupBox.Size = new System.Drawing.Size(117, 54);
      this.productPrice__groupBox.TabIndex = 118;
      this.productPrice__groupBox.TabStop = false;
      this.productPrice__groupBox.Text = "Цена";
      // 
      // productPrice_textBox
      // 
      this.productPrice_textBox.Location = new System.Drawing.Point(6, 14);
      this.productPrice_textBox.MaxLength = 10;
      this.productPrice_textBox.Name = "productPrice_textBox";
      this.productPrice_textBox.Size = new System.Drawing.Size(101, 20);
      this.productPrice_textBox.TabIndex = 4;
      // 
      // productName_groupBox
      // 
      this.productName_groupBox.Controls.Add(this.productName_textBox);
      this.productName_groupBox.Location = new System.Drawing.Point(682, 12);
      this.productName_groupBox.Name = "productName_groupBox";
      this.productName_groupBox.Size = new System.Drawing.Size(179, 54);
      this.productName_groupBox.TabIndex = 117;
      this.productName_groupBox.TabStop = false;
      this.productName_groupBox.Text = "Товар";
      // 
      // productName_textBox
      // 
      this.productName_textBox.Location = new System.Drawing.Point(6, 14);
      this.productName_textBox.MaxLength = 35;
      this.productName_textBox.Name = "productName_textBox";
      this.productName_textBox.Size = new System.Drawing.Size(163, 20);
      this.productName_textBox.TabIndex = 3;
      // 
      // products
      // 
      this.products.AllowUserToAddRows = false;
      this.products.AllowUserToDeleteRows = false;
      this.products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_product,
            this.product_product,
            this.price_product,
            this.action_product});
      this.products.Location = new System.Drawing.Point(688, 66);
      this.products.MultiSelect = false;
      this.products.Name = "products";
      this.products.ReadOnly = true;
      this.products.RowHeadersVisible = false;
      this.products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.products.Size = new System.Drawing.Size(373, 311);
      this.products.TabIndex = 119;
      this.products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_CellContentClick);
      this.products.SelectionChanged += new System.EventHandler(this.products_SelectionChanged_1);
      // 
      // id_product
      // 
      this.id_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.id_product.FillWeight = 25F;
      this.id_product.HeaderText = "id";
      this.id_product.Name = "id_product";
      this.id_product.ReadOnly = true;
      // 
      // product_product
      // 
      this.product_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.product_product.FillWeight = 70F;
      this.product_product.HeaderText = "Товар";
      this.product_product.Name = "product_product";
      this.product_product.ReadOnly = true;
      // 
      // price_product
      // 
      this.price_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.price_product.FillWeight = 70F;
      this.price_product.HeaderText = "Цена";
      this.price_product.Name = "price_product";
      this.price_product.ReadOnly = true;
      // 
      // action_product
      // 
      this.action_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.action_product.FillWeight = 60F;
      this.action_product.HeaderText = "Действие";
      this.action_product.Name = "action_product";
      this.action_product.ReadOnly = true;
      this.action_product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.action_product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // closeButton
      // 
      this.closeButton.AutoSize = true;
      this.closeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.closeButton.Location = new System.Drawing.Point(1043, 5);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(16, 15);
      this.closeButton.TabIndex = 120;
      this.closeButton.Text = "X";
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // Adminpage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(1071, 430);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.addProduct_button);
      this.Controls.Add(this.productPrice__groupBox);
      this.Controls.Add(this.productName_groupBox);
      this.Controls.Add(this.products);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.add_product_to_shop_button);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox7);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.add_button);
      this.Controls.Add(this.address_groupBox);
      this.Controls.Add(this.name_groupBox);
      this.Controls.Add(this.shops);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Adminpage";
      this.Text = "Adminpage";
      this.Load += new System.EventHandler(this.Adminpage_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Adminpage_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Adminpage_MouseMove);
      this.address_groupBox.ResumeLayout(false);
      this.address_groupBox.PerformLayout();
      this.name_groupBox.ResumeLayout(false);
      this.name_groupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.shops)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.extra_charge_numericUpDown)).EndInit();
      this.groupBox7.ResumeLayout(false);
      this.productPrice__groupBox.ResumeLayout(false);
      this.productPrice__groupBox.PerformLayout();
      this.productName_groupBox.ResumeLayout(false);
      this.productName_groupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button add_button;
    private System.Windows.Forms.GroupBox address_groupBox;
    private System.Windows.Forms.TextBox address_textBox;
    private System.Windows.Forms.GroupBox name_groupBox;
    private System.Windows.Forms.TextBox name_textBox;
    private System.Windows.Forms.DataGridView shops;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox district_textbox;
    private System.Windows.Forms.DataGridViewTextBoxColumn Название;
    private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
    private System.Windows.Forms.DataGridViewTextBoxColumn Район;
    private System.Windows.Forms.DataGridViewTextBoxColumn district;
    private System.Windows.Forms.DataGridViewButtonColumn Действие;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.NumericUpDown count_numericUpDown;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label price_label;
    private System.Windows.Forms.Button add_product_to_shop_button;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label shop_label;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label price_with_extra_charge_label;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.NumericUpDown extra_charge_numericUpDown;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.Label product_name_label;
    private System.Windows.Forms.Button addProduct_button;
    private System.Windows.Forms.GroupBox productPrice__groupBox;
    private System.Windows.Forms.TextBox productPrice_textBox;
    private System.Windows.Forms.GroupBox productName_groupBox;
    private System.Windows.Forms.TextBox productName_textBox;
    private System.Windows.Forms.DataGridView products;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_product;
    private System.Windows.Forms.DataGridViewTextBoxColumn product_product;
    private System.Windows.Forms.DataGridViewTextBoxColumn price_product;
    private System.Windows.Forms.DataGridViewButtonColumn action_product;
    private System.Windows.Forms.Label closeButton;
  }
}