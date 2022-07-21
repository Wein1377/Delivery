using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
  public partial class WhoAreYou : Form
  {
    public WhoAreYou(int customer_id, string customer_name, string customer_address)
    {
      InitializeComponent();
      this.customer_id = customer_id;
      this.customer_name = customer_name;
      this.customer_address = customer_address;
    }
    int customer_id;
    string customer_name;
    string customer_address;
    private void closeButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void label1_MouseHover(object sender, EventArgs e)
    {
      label1.ForeColor = Color.White;
    }

    private void label1_MouseLeave(object sender, EventArgs e)
    {
      label1.ForeColor = Color.Black;
    }
    Point lastpoint;

    private void splitter2_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - lastpoint.X;
        this.Top += e.Y - lastpoint.Y;
      }
    }

    private void splitter2_MouseDown(object sender, MouseEventArgs e)
    {
      lastpoint = new Point(e.X, e.Y);
    }
    Point lastPoint;
    private void splitter1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - lastPoint.X;
        this.Top += e.Y - lastPoint.Y;
      }
    }

    private void splitter1_MouseDown(object sender, MouseEventArgs e)
    {
      lastPoint = new Point(e.X, e.Y);
    }

    private void label2_MouseHover(object sender, EventArgs e)
    {
      label2.ForeColor = Color.White;
    }

    private void label2_MouseLeave(object sender, EventArgs e)
    {
      label2.ForeColor = Color.Black;
    }

    private void label2_Click(object sender, EventArgs e)
    {
      Order order = new Order(customer_id,customer_name, customer_address);
       order.Show();
      this.Close();
    }
  }
}
