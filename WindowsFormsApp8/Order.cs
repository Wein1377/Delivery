using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace WindowsFormsApp8
{
  public partial class Order : Form
  {
    DATA db = new DATA();
    public Order(int customer_id, string customer_name, string customer_address)
    {
      InitializeComponent();
      this.customer_id = customer_id;
      this.customer_name = customer_name;
      this.customer_address = customer_address;
    }
    int customer_id;
    string customer_name;
    string customer_address;
    Dictionary<string, int> shops = new Dictionary<string, int>();
    private void addToCart(int product_id)
    {
      bool alreadyExists = false;
      int existingRow = 0;
      DataGridViewRowCollection cart = this.cart_table.Rows;

      foreach (DataGridViewRow row in cart)
      {
        if (product_id == Convert.ToInt32(row.Cells[0].Value))
        {
          alreadyExists = true;
          existingRow = row.Index;
        }
      }

      if (alreadyExists)
      {
        int storage_count = Convert.ToInt32(this.shop_products_table.SelectedRows[0].Cells[3].Value);
        int currentCount = Convert.ToInt32(this.cart_table.Rows[existingRow].Cells[3].Value);

        if (currentCount >= storage_count)
        {
          MessageBox.Show("На складе больше не осталось данного товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
          this.cart_table.Rows[existingRow].Cells[3].Value = ++currentCount;
        }
      }
      else
      {
        int index = Convert.ToInt32(this.shop_products_table.SelectedRows[0].Cells[0].Value);
        string name = this.shop_products_table.SelectedRows[0].Cells[1].Value.ToString();
        double price = Convert.ToDouble(this.shop_products_table.SelectedRows[0].Cells[2].Value);

        this.cart_table.Rows.Add(index, name, price, 1, "Удалить");
      }
    }

    private void removeFromCart()
    {
      int count = Convert.ToInt32(this.cart_table.SelectedRows[0].Cells[3].Value);

      if (count == 1)
      {
        int currentRow = this.cart_table.SelectedRows[0].Cells[0].RowIndex;
        this.cart_table.Rows.RemoveAt(currentRow);
      }
      else
      {
        int currentCount = Convert.ToInt32(this.cart_table.SelectedRows[0].Cells[3].Value);
        this.cart_table.SelectedRows[0].Cells[3].Value = --currentCount;
      }
    }

    private void getshopsCombobox()
    {
      shops.Clear();
      this.shops_combobox.Items.Clear();

      db.openConnection();    
      MySqlCommand commmand = new MySqlCommand("SELECT * FROM shops",db.getConnection());
      using (DbDataReader reader = commmand.ExecuteReader())
      {
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            int id = reader.GetInt32(reader.GetOrdinal("id"));
            string name = reader.GetString(reader.GetOrdinal("name"));
            string address = reader.GetString(reader.GetOrdinal("address"));

            string full_name = name + " [" + address + "]";

            shops.Add(full_name, id);

            this.shops_combobox.Items.Add(full_name);
          }
        }
      }

      db.closeConnection();

      this.shops_combobox.SelectedIndex = 0;
    }

    private void getShopProductsTable()
    {
      db.openConnection();

      MySqlCommand command = new MySqlCommand("SELECT pr.id, pr.name, prh.price_with_charge, prh.count FROM products_to_shop prh " +
                   "JOIN shops ph ON ph.id = prh.shop_id " +
                   "JOIN pro pr ON pr.id = prh.product_id " +
                   "WHERE ph.id = @shop_id", db.getConnection());

      command.Parameters.Add("@shop_id", MySqlDbType.Int32).Value = shops[this.shops_combobox.SelectedItem.ToString()];

      using (DbDataReader reader = command.ExecuteReader())
      {
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            int index = reader.GetInt32(reader.GetOrdinal("id"));
            string name = reader.GetString(reader.GetOrdinal("name"));
            double price = reader.GetInt32(reader.GetOrdinal("price_with_charge"));
            int count = reader.GetInt32(reader.GetOrdinal("count"));

            this.shop_products_table.Rows.Add(index, name, price, count, "Добавить");
          }
        }
        db.closeConnection();
      }
    }

    private void clearShopProductsTable()
    {
      this.shop_products_table.Rows.Clear();
      this.shop_products_table.Refresh();
    }

    private void clearCartTable()
    {
      this.cart_table.Rows.Clear();
      this.cart_table.Refresh();
    }

    private void calculateCart()
    {
      DataGridViewRowCollection cart = this.cart_table.Rows;

      if (cart.Count == 0)
      {
        this.sum_label.Text = "-";
        this.total_count_label.Text = "-";
        this.order_button.Enabled = false;
      }
      else
      {
        double sum = 0;
        int count = 0;

        foreach (DataGridViewRow row in cart)
        {
          double this_price = Convert.ToDouble(row.Cells[2].Value);
          int this_count = Convert.ToInt32(row.Cells[3].Value);
          sum += (this_price * this_count);
          count += this_count;
        }

        this.sum_label.Text = sum.ToString();
        this.total_count_label.Text = count.ToString();
        this.order_button.Enabled = true;
      }
    }

    private void Order_Load_1(object sender, EventArgs e)
    {
      getshopsCombobox();
    }

    private void shops_combobox_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      clearShopProductsTable();
      getShopProductsTable();
      clearCartTable();
    }

    private void shop_products_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {
      if (this.shop_products_table.Columns[e.ColumnIndex].Name == "action_product_shop")
      {
        addToCart(Convert.ToInt32(this.shop_products_table.SelectedRows[0].Cells[0].Value));
        calculateCart();
      }
    }

    private void cart_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {
      if (this.cart_table.Columns[e.ColumnIndex].Name == "action_product_cart")
      {
        removeFromCart();
        calculateCart();
      }
    }
    private int getPrhId(int shop_id, int product_id)
    {
      db.openConnection();

      MySqlCommand command = new MySqlCommand("SELECT id, count FROM products_to_shop WHERE shop_id = @shop_id AND product_id = @product_id AND count > 0", db.getConnection());

      command.Parameters.Add("@shop_id", MySqlDbType.Int32).Value = shop_id;
      command.Parameters.Add("@product_id", MySqlDbType.Int32).Value = product_id;

      using (DbDataReader reader = command.ExecuteReader())
      {
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            int id = reader.GetInt32(reader.GetOrdinal("id"));

            db.closeConnection();

            return id;
          }
        }
      }

      return 0;
    }

    private void order_button_Click(object sender, EventArgs e)
    {
      string shop = Convert.ToString(shops_combobox.SelectedItem);
      int total_count = Convert.ToInt32(this.total_count_label.Text);
      double sum = Convert.ToDouble(this.sum_label.Text);

      string text = "Доставка:\n[Откуда] " + shop + "\n[Куда] " + customer_address + '\n';
      text += "Заказчик: " + customer_name + "\n\n";

      DataGridViewRowCollection cart = this.cart_table.Rows;
      Dictionary<int, int> products = new Dictionary<int, int>();

      foreach (DataGridViewRow row in cart)
      {
        int product_id = Convert.ToInt32(row.Cells[0].Value);
        string product_name = Convert.ToString(row.Cells[1].Value);
        double product_price = Convert.ToDouble(row.Cells[2].Value);
        int product_count = Convert.ToInt32(row.Cells[3].Value);

        double product_sum = product_price * product_count;

        products.Add(product_id, product_count);

        text += (product_name + " -- " + product_price + " руб. -- " + product_count + " шт. -- " + product_sum + " руб.\n");
      }

      double discount = sum / 100 * 20;

      text += "----------------------------------------------------------------\n";
      text += ("Доставка: " + discount + " руб.\n");
      text += ("Кол-во товаров: " + total_count + " шт.\n\n");
      text += ("Итог: " + (sum + discount) + " руб.");

      DialogResult result = MessageBox.Show(text, "Подтверждение заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

      if (result == DialogResult.Yes)
      {
        db.openConnection();

        MySqlCommand commandInsert = new MySqlCommand("UPDATE products_to_shop SET count = count - @count WHERE id = @id", db.getConnection());

        foreach (KeyValuePair<int, int> product in products)
        {
         
         
          int shop_id = shops[shop];
          int prh_id = getPrhId(shop_id, product.Key);
          commandInsert.Parameters.Clear();
          commandInsert.Parameters.Add("@id", MySqlDbType.Int32).Value = prh_id;
          commandInsert.Parameters.Add("@count", MySqlDbType.Int32).Value = product.Value;
          db.openConnection();
          commandInsert.ExecuteNonQuery();
          db.closeConnection();
        }

        MessageBox.Show("Заказ успешно оформлен.\nОжидайте доставку.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        clearCartTable();
        clearShopProductsTable();
        getShopProductsTable();
        calculateCart();


        db.closeConnection();
      
      }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
    Point LastPoint;

    private void Order_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - LastPoint.X;
        this.Top += e.Y - LastPoint.Y;
      }
    }

    private void Order_MouseDown(object sender, MouseEventArgs e)
    {
      LastPoint = new Point(e.X, e.Y);
    }
  }
}


  

