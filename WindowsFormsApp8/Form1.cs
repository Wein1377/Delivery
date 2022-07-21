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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      logField.Text = "Введите логин";
      passField.Text = "Введите пароль";
    }
    private void closeButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    Point lastPoint;
    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - lastPoint.X;
        this.Top += e.Y - lastPoint.Y;
      }
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
      lastPoint = new Point(e.X, e.Y);
    }

    private void aut_Click(object sender, EventArgs e)
    {
      String login = logField.Text;
      String pass = passField.Text;

      DATA db = new DATA();
      DataTable table = new DataTable();
      MySqlDataAdapter adapter = new MySqlDataAdapter();

      MySqlCommand command = new MySqlCommand("SELECT * FROM `customers` WHERE `login`=@uL and `password`=@uP", db.getConnection());
      command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
      command.Parameters.Add("@uP", MySqlDbType.Int32).Value = pass;

      adapter.SelectCommand = command;
      adapter.Fill(table);
      db.openConnection();
      using (DbDataReader reader = command.ExecuteReader())
      {
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            int id = reader.GetInt32(reader.GetOrdinal("id"));
            string name = reader.GetString(reader.GetOrdinal("name"));
            string password = reader.GetString(reader.GetOrdinal("password"));
            string address = reader.GetString(reader.GetOrdinal("address"));

            if (password.Equals(this.passField.Text))
            {
              WhoAreYou who = new WhoAreYou(id, name, address);
              who.Show();
              this.Hide();
            }
            else
            {
              MessageBox.Show("Неверный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
        }
        else
        {
          MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      db.closeConnection();
    }

    private void reg_Click(object sender, EventArgs e)
    {
      this.Hide();
      Register registerform = new Register();
      registerform.Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Adminpage admin = new Adminpage();
      admin.Show();
    }

    private void logField_Enter_1(object sender, EventArgs e)
    {
      if (logField.Text == "Введите логин")
        logField.Text = "";
    }

    private void logField_Leave_1(object sender, EventArgs e)
    {
        if (logField.Text == "")
        logField.Text = "Введите логин";
    }

    private void passField_Enter_1(object sender, EventArgs e)
    {
      if (passField.Text == "Введите пароль")
        passField.Text = "";
    }

    private void passField_Leave_1(object sender, EventArgs e)
    {
      if (passField.Text == "")
        passField.Text = "Введите пароль";
    }
  }
}
  