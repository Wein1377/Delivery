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

namespace WindowsFormsApp8
{
  public partial class Register : Form
  {
    public Register()
    {
      InitializeComponent();

      Username.Text = "Введите имя";
      logField.Text = "+7(9__)___ __ __";
      passField.Text = "Введите пароль";
      address_field.Text = "Введите адрес";
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
    
    private void Register_Load(object sender, EventArgs e)
    {

    }
    Point LastPoint;
    private void Register_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - LastPoint.X;
        this.Top += e.Y - LastPoint.Y;
      }
    }

    private void Register_MouseDown(object sender, MouseEventArgs e)
    {
      LastPoint = new Point(e.X, e.Y);
    }

    private void Username_Enter(object sender, EventArgs e)
    {
      if (Username.Text == "Введите имя")
      Username.Text = "";
    }

    private void Username_Leave(object sender, EventArgs e)
    {
      if (Username.Text == "")
        Username.Text = "Введите имя";
    }

    private void logField_Enter(object sender, EventArgs e)
    {
      if (logField.Text == "+7(9__)___ __ __")
      logField.Text = "";

    }

    private void logField_Leave(object sender, EventArgs e)
    {
      if (logField.Text == "")
        logField.Text = "+7(9__)___ __ __";
    }
    private void address_field_Enter(object sender, EventArgs e)
    {
      if (address_field.Text == "Введите адрес")
        address_field.Text = "";
    }

    private void address_field_Leave(object sender, EventArgs e)
    {
      if (address_field.Text == "")
        address_field.Text = "Введите адрес";
    }
    private void passField_Enter(object sender, EventArgs e)
    {
      if (passField.Text == "Введите пароль")
        passField.Text = "";
    }

    private void passField_Leave(object sender, EventArgs e)
    {
      if (passField.Text == "")
        passField.Text = "Введите пароль";
    }

    private void reg_Click(object sender, EventArgs e)
    {
      if (Username.Text == "Введите имя")
      {
        MessageBox.Show("Введите имя");
        return;
      }
      if (logField.Text == "+7(9__)___ __ __")
      {
        MessageBox.Show("Введите логин");
        return;
      }
      if (passField.Text == "Введите пароль")
      {
        MessageBox.Show("Введите пароль");
        return;
      }
      if (address_field.Text == "Введите адрес")
      {
        MessageBox.Show("Введите адрес");
        return;
      }

      if (checkUser())
        return;

      DATA db = new DATA();
      MySqlCommand command = new MySqlCommand("INSERT INTO `customers` (`login`, `password`, `Name`, `address`) VALUES (@login, @password, @name, @address);", db.getConnection());

      command.Parameters.Add("@login", MySqlDbType.VarChar).Value = logField.Text;
      command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
      command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Username.Text;
      command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address_field.Text;

      db.openConnection();

      if (command.ExecuteNonQuery() == 1)
      {
        MessageBox.Show("Аккаунт успешно создан");
        this.Hide();
        Form1 login = new Form1();
        login.Show();
      }
      else
        MessageBox.Show("Ошибка");
      db.closeConnection();
    }
    public Boolean checkUser()
    {
    DATA db = new DATA();
    DataTable table = new DataTable();
    MySqlDataAdapter adapter = new MySqlDataAdapter();

    MySqlCommand command = new MySqlCommand("SELECT * FROM `customers` WHERE `login`=@uL" , db.getConnection());
    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logField.Text;

      
    adapter.SelectCommand = command;
    adapter.Fill(table);

      if (table.Rows.Count > 0)
      {
        MessageBox.Show("Логин занят");
        return true;
      }
      else
        return false;
    }
  }
}
