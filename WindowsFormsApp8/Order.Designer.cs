
namespace WindowsFormsApp8
{
  partial class Order
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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.order_button = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.total_count_label = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.sum_label = new System.Windows.Forms.Label();
      this.cart_table = new System.Windows.Forms.DataGridView();
      this.id_product_cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.name_product_cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.price_product_cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.count_product_cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.action_product_cart = new System.Windows.Forms.DataGridViewButtonColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.shops_combobox = new System.Windows.Forms.ComboBox();
      this.shop_products_table = new System.Windows.Forms.DataGridView();
      this.id_product_shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.name_product_shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.price_product_shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.count_product_shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.action_product_shop = new System.Windows.Forms.DataGridViewButtonColumn();
      this.closeButton = new System.Windows.Forms.Label();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cart_table)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.shop_products_table)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.order_button);
      this.groupBox2.Controls.Add(this.groupBox4);
      this.groupBox2.Controls.Add(this.groupBox3);
      this.groupBox2.Location = new System.Drawing.Point(372, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(350, 55);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Итог";
      // 
      // order_button
      // 
      this.order_button.Enabled = false;
      this.order_button.Location = new System.Drawing.Point(238, 19);
      this.order_button.Name = "order_button";
      this.order_button.Size = new System.Drawing.Size(105, 27);
      this.order_button.TabIndex = 2;
      this.order_button.Text = "Заказать";
      this.order_button.UseVisualStyleBackColor = true;
      this.order_button.Click += new System.EventHandler(this.order_button_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.total_count_label);
      this.groupBox4.Location = new System.Drawing.Point(122, 12);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(110, 37);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Кол-во товаров";
      // 
      // total_count_label
      // 
      this.total_count_label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.total_count_label.Location = new System.Drawing.Point(3, 16);
      this.total_count_label.Name = "total_count_label";
      this.total_count_label.Size = new System.Drawing.Size(104, 18);
      this.total_count_label.TabIndex = 0;
      this.total_count_label.Text = "-";
      this.total_count_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.sum_label);
      this.groupBox3.Location = new System.Drawing.Point(6, 12);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(110, 37);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Сумма";
      // 
      // sum_label
      // 
      this.sum_label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sum_label.Location = new System.Drawing.Point(3, 16);
      this.sum_label.Name = "sum_label";
      this.sum_label.Size = new System.Drawing.Size(104, 18);
      this.sum_label.TabIndex = 0;
      this.sum_label.Text = "-";
      this.sum_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cart_table
      // 
      this.cart_table.AllowUserToAddRows = false;
      this.cart_table.AllowUserToDeleteRows = false;
      this.cart_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.cart_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.cart_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cart_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_product_cart,
            this.name_product_cart,
            this.price_product_cart,
            this.count_product_cart,
            this.action_product_cart});
      this.cart_table.Location = new System.Drawing.Point(372, 73);
      this.cart_table.MultiSelect = false;
      this.cart_table.Name = "cart_table";
      this.cart_table.ReadOnly = true;
      this.cart_table.RowHeadersVisible = false;
      this.cart_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.cart_table.Size = new System.Drawing.Size(350, 250);
      this.cart_table.TabIndex = 6;
      this.cart_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cart_table_CellContentClick_1);
      // 
      // id_product_cart
      // 
      this.id_product_cart.HeaderText = "id";
      this.id_product_cart.Name = "id_product_cart";
      this.id_product_cart.ReadOnly = true;
      this.id_product_cart.Width = 40;
      // 
      // name_product_cart
      // 
      this.name_product_cart.HeaderText = "Название";
      this.name_product_cart.Name = "name_product_cart";
      this.name_product_cart.ReadOnly = true;
      this.name_product_cart.Width = 82;
      // 
      // price_product_cart
      // 
      this.price_product_cart.HeaderText = "Цена";
      this.price_product_cart.Name = "price_product_cart";
      this.price_product_cart.ReadOnly = true;
      this.price_product_cart.Width = 58;
      // 
      // count_product_cart
      // 
      this.count_product_cart.HeaderText = "Кол-во";
      this.count_product_cart.Name = "count_product_cart";
      this.count_product_cart.ReadOnly = true;
      this.count_product_cart.Width = 66;
      // 
      // action_product_cart
      // 
      this.action_product_cart.HeaderText = "Удалить";
      this.action_product_cart.Name = "action_product_cart";
      this.action_product_cart.ReadOnly = true;
      this.action_product_cart.Width = 56;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.shops_combobox);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(349, 55);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Магазин";
      // 
      // shops_combobox
      // 
      this.shops_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.shops_combobox.FormattingEnabled = true;
      this.shops_combobox.Location = new System.Drawing.Point(6, 21);
      this.shops_combobox.Name = "shops_combobox";
      this.shops_combobox.Size = new System.Drawing.Size(337, 21);
      this.shops_combobox.TabIndex = 2;
      this.shops_combobox.SelectedIndexChanged += new System.EventHandler(this.shops_combobox_SelectedIndexChanged_1);
      // 
      // shop_products_table
      // 
      this.shop_products_table.AllowUserToAddRows = false;
      this.shop_products_table.AllowUserToDeleteRows = false;
      this.shop_products_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.shop_products_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.shop_products_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.shop_products_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_product_shop,
            this.name_product_shop,
            this.price_product_shop,
            this.count_product_shop,
            this.action_product_shop});
      this.shop_products_table.Location = new System.Drawing.Point(12, 73);
      this.shop_products_table.MultiSelect = false;
      this.shop_products_table.Name = "shop_products_table";
      this.shop_products_table.ReadOnly = true;
      this.shop_products_table.RowHeadersVisible = false;
      this.shop_products_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.shop_products_table.Size = new System.Drawing.Size(350, 250);
      this.shop_products_table.TabIndex = 4;
      this.shop_products_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shop_products_table_CellContentClick_1);
      // 
      // id_product_shop
      // 
      this.id_product_shop.HeaderText = "id";
      this.id_product_shop.Name = "id_product_shop";
      this.id_product_shop.ReadOnly = true;
      this.id_product_shop.Width = 40;
      // 
      // name_product_shop
      // 
      this.name_product_shop.HeaderText = "Название";
      this.name_product_shop.Name = "name_product_shop";
      this.name_product_shop.ReadOnly = true;
      this.name_product_shop.Width = 82;
      // 
      // price_product_shop
      // 
      this.price_product_shop.HeaderText = "Цена";
      this.price_product_shop.Name = "price_product_shop";
      this.price_product_shop.ReadOnly = true;
      this.price_product_shop.Width = 58;
      // 
      // count_product_shop
      // 
      this.count_product_shop.HeaderText = "В наличии";
      this.count_product_shop.Name = "count_product_shop";
      this.count_product_shop.ReadOnly = true;
      this.count_product_shop.Width = 83;
      // 
      // action_product_shop
      // 
      this.action_product_shop.HeaderText = "Добавить";
      this.action_product_shop.Name = "action_product_shop";
      this.action_product_shop.ReadOnly = true;
      this.action_product_shop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.action_product_shop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.action_product_shop.Width = 82;
      // 
      // closeButton
      // 
      this.closeButton.AutoSize = true;
      this.closeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.closeButton.Location = new System.Drawing.Point(743, 9);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(16, 15);
      this.closeButton.TabIndex = 8;
      this.closeButton.Text = "X";
      this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
      // 
      // Order
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(771, 362);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.cart_table);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.shop_products_table);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Order";
      this.Text = "Order";
      this.Load += new System.EventHandler(this.Order_Load_1);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Order_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Order_MouseMove);
      this.groupBox2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cart_table)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.shop_products_table)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button order_button;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label total_count_label;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label sum_label;
    private System.Windows.Forms.DataGridView cart_table;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_product_cart;
    private System.Windows.Forms.DataGridViewTextBoxColumn name_product_cart;
    private System.Windows.Forms.DataGridViewTextBoxColumn price_product_cart;
    private System.Windows.Forms.DataGridViewTextBoxColumn count_product_cart;
    private System.Windows.Forms.DataGridViewButtonColumn action_product_cart;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox shops_combobox;
    private System.Windows.Forms.DataGridView shop_products_table;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_product_shop;
    private System.Windows.Forms.DataGridViewTextBoxColumn name_product_shop;
    private System.Windows.Forms.DataGridViewTextBoxColumn price_product_shop;
    private System.Windows.Forms.DataGridViewTextBoxColumn count_product_shop;
    private System.Windows.Forms.DataGridViewButtonColumn action_product_shop;
    private System.Windows.Forms.Label closeButton;
  }
}