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
  public partial class Adminpage : Form
  {
    public Adminpage()
    {
      InitializeComponent();
    }
    private void clearShops()
    {
      this.shops.Rows.Clear();
      this.shops.Refresh();
    }
    private void clearProducts()
    {
      this.products.Rows.Clear();
      this.products.Refresh();
    }
     DATA db = new DATA();
    private void getShops()
    {
      db.openConnection();
      MySqlCommand command = new MySqlCommand("SELECT * FROM shops", db.getConnection());
      using (DbDataReader reader = command.ExecuteReader())
      {
        if (reader.HasRows)
        {
          while(reader.Read())
          {
            int index = reader.GetInt32(reader.GetOrdinal("id"));
            string name = reader.GetString(reader.GetOrdinal("name"));
            string address = reader.GetString(reader.GetOrdinal("address"));
            string district = reader.GetString(reader.GetOrdinal("district"));
            this.shops.Rows.Add(index, name, address, district, "Удалить");
          }
        }
        db.closeConnection();
      }
    }
    private void getProducts()
    {
      db.openConnection();
      MySqlCommand command = new MySqlCommand("SELECT * FROM pro", db.getConnection());
      using (DbDataReader reader = command.ExecuteReader())
      {
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            int index = reader.GetInt32(reader.GetOrdinal("id"));
            string name = reader.GetString(reader.GetOrdinal("name"));
            string price = reader.GetDecimal(reader.GetOrdinal("price")).ToString();

            this.products.Rows.Add(index, name, price, "Удалить");
          }
        }
      }
    }
    private void calculatePrice()
    {
      double price = Convert.ToDouble(this.price_label.Text.ToString());
      int extra_charge = Convert.ToInt32(this.extra_charge_numericUpDown.Value);
      double price_with_extra_charge = price + (price / 100 * extra_charge);

      this.price_with_extra_charge_label.Text = price_with_extra_charge.ToString();
    }
    private void Adminpage_Load(object sender, EventArgs e)
    {
      getShops();
      getProducts();
    }
    private bool Existense()
     
    {
      db.openConnection();
      MySqlCommand command = new MySqlCommand("SELECT * FROM products_to_shop WHERE shop_id = @shop_id AND product_id = @product_id AND count > 0",db.getConnection());

      command.Parameters.Add("@shop_id", MySqlDbType.Int32).Value = this.shops.CurrentRow.Cells[0].Value;
      command.Parameters.Add("@product_id", MySqlDbType.Int32).Value = this.products.CurrentRow.Cells[0].Value;
      using (DbDataReader reader = command.ExecuteReader())
      {
       

        if (reader.HasRows)
        {
          db.closeConnection();
          return true;
        }
        else
        {
          db.closeConnection();
          return false;
        }
        
      }
    }
    private void check()
    {
      this.extra_charge_numericUpDown.Value = 0;
      this.count_numericUpDown.Value = 1;

      DataGridViewRowCollection shops = this.shops.Rows;
      DataGridViewRowCollection pro = this.products.Rows;

      bool shopsAreNull = shops.Count == 0;
      bool proAreNull = pro.Count == 0;

      if (shopsAreNull)
      {
        this.shop_label.Text = "-";
        this.add_product_to_shop_button.Enabled = false;
      }
      else
      {
        this.shop_label.Text = this.shops.CurrentRow.Cells[1].Value.ToString();
        this.add_product_to_shop_button.Enabled = true;
      }

      if (proAreNull)
      {
        this.product_name_label.Text = "-";
        this.price_label.Text = "-";
        this.price_with_extra_charge_label.Text = "-";
        this.add_product_to_shop_button.Enabled = false;
      }
      else
      {
        this.product_name_label.Text = this.products.CurrentRow.Cells[1].Value.ToString();
        this.price_label.Text = this.products.CurrentRow.Cells[2].Value.ToString();
        this.add_product_to_shop_button.Enabled = true;

        calculatePrice();
      }
    }
    private void add_button_Click_1(object sender, EventArgs e)

    {
      string name = this.name_textBox.Text;
      string address = this.address_textBox.Text;
      string district = this.district_textbox.Text;

      if (name.Length < 3 || address.Length == 0 || district.Length == 0)
      {
        MessageBox.Show("Не все поля заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
        MySqlCommand command = new MySqlCommand("INSERT INTO `shops` (`name`, `address`, `district`) VALUES (@name, @address, @district);", db.getConnection());

        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = this.name_textBox.Text;
        command.Parameters.Add("@address", MySqlDbType.VarChar).Value = this.address_textBox.Text;
        command.Parameters.Add("@district", MySqlDbType.VarChar).Value = this.district_textbox.Text;
        db.openConnection();

        if (command.ExecuteNonQuery() == 1)
          MessageBox.Show("Магазин добавлен");
        else
          MessageBox.Show("Ошибка");
        db.closeConnection();
      clearShops();
      getShops();
      }

    private void shops_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {
      if (this.shops.Columns[e.ColumnIndex].Name == "Действие")
      {
        int currentLineIndex = this.shops.CurrentCell.RowIndex;
        DataGridViewRow currentRow = this.shops.Rows[currentLineIndex];

        string currentIndexStr = currentRow.Cells[0].Value.ToString();
        int currentIndex = Convert.ToInt32(currentIndexStr);

        string currentshop = currentRow.Cells[1].Value.ToString();

        DialogResult deletitionResult = MessageBox.Show("Вы действительно хотите удалить магазин \"" + currentshop + "\"?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (deletitionResult == DialogResult.Yes)
        {
          db.openConnection();
          try
          {
            MySqlCommand command = new MySqlCommand("DELETE FROM `shops` WHERE `id`=@id", db.getConnection());

            command.CommandText = "DELETE FROM shops WHERE id = @id";

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = currentIndex;

            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно удалена из базы данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearShops();
            getShops();
            db.closeConnection();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Произошла ошибка, попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(ex.StackTrace, "Ошибка");
          }
          finally
          {

          }
        }

      }
    }


    private void extra_charge_numericUpDown_ValueChanged_1(object sender, EventArgs e)
    {
      calculatePrice();
    }

    private void products_SelectionChanged_1(object sender, EventArgs e)
    {
      check();
    }

    private void shops_SelectionChanged_1(object sender, EventArgs e)
    {
      check();
    }

    private void products_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.products.Columns[e.ColumnIndex].Name == "action_product")
      {
        int currentLineIndex = this.products.CurrentCell.RowIndex;
        DataGridViewRow currentRow = this.products.Rows[currentLineIndex];

        string currentIndexStr = currentRow.Cells[0].Value.ToString();
        int currentIndex = Convert.ToInt32(currentIndexStr);

        string currentProduct = currentRow.Cells[1].Value.ToString();

        DialogResult deletitionResult = MessageBox.Show("Вы действительно хотите удалить товар \"" + currentProduct + "\"?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (deletitionResult == DialogResult.Yes)
        {
          db.openConnection();

          try
          {
            MySqlCommand command = new MySqlCommand("DELETE FROM pro WHERE id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = currentIndex;
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно удалена из базы данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearProducts();
            getProducts();
            check();
          }
          catch (Exception)
          {
            MessageBox.Show("Произошла ошибка, попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          finally
          {
            db.closeConnection();
          }
        }

      }
    }

    private void addProduct_button_Click(object sender, EventArgs e)
    {

      string name = this.productName_textBox.Text;
      string price = this.productPrice_textBox.Text;

      if (name.Length < 4 || price.Length == 0)
      {
        MessageBox.Show("Не все поля заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      db.openConnection();

      try
      {

        MySqlCommand command = new MySqlCommand("INSERT INTO pro(name, price) VALUES (@name, @price)", db.getConnection());

        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
        command.Parameters.Add("@price", MySqlDbType.Int32).Value = price;

        command.ExecuteNonQuery();

        MessageBox.Show("Запись успешно добавлена в базу данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        clearProducts();
        getProducts();

        this.productName_textBox.Clear();
        this.productPrice_textBox.Clear();
      }
      catch (Exception)
      {
        MessageBox.Show("Произошла ошибка, попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        db.closeConnection();
      }
    }

    private void add_product_to_shop_button_Click(object sender, EventArgs e)
    {
      if (Existense())
      {
        MessageBox.Show("Товар уже есть в магазине.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      db.openConnection();

      try
      {
        MySqlCommand command = new MySqlCommand("INSERT INTO product_to_shop (shop_id, product_id, charge, price_with_charge, count) " +
          " VALUES (@shop_id, @product_id, @charge, @price_with_charge, @count)",db.getConnection());


        command.Parameters.Add("@pharmacy_id", MySqlDbType.Int32).Value = this.shops.CurrentRow.Cells[0].Value;
        command.Parameters.Add("@product_id", MySqlDbType.Int32).Value = this.products.CurrentRow.Cells[0].Value;
        command.Parameters.Add("@charge", MySqlDbType.Int32).Value = this.extra_charge_numericUpDown.Value;
        command.Parameters.Add("@price_with_charge", MySqlDbType.Float).Value = this.price_with_extra_charge_label.Text;
        command.Parameters.Add("@count", MySqlDbType.Int32).Value = this.count_numericUpDown.Value;

        command.ExecuteNonQuery();

        MessageBox.Show("Запись успешно добавлена в базу данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception)
      {
        MessageBox.Show("Произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        db.closeConnection();
      }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
    Point LastPoint;

    private void Adminpage_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - LastPoint.X;
        this.Top += e.Y - LastPoint.Y;
      }
    }

    private void Adminpage_MouseDown(object sender, MouseEventArgs e)
    {
      LastPoint = new Point(e.X, e.Y);
    }
  }
 }
  

