using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock_Managemet_System
{
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }

        private void supplier_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into supplier (supCode,supName,supPhone,supAdd) values(@nic,@name,@phone,@add)", con);
            cmd.Parameters.AddWithValue("@nic", int.Parse(gunaTextBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            //cmd.Parameters.AddWithValue("@phone", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@add", textBox3.Text);
            //cmd.Parameters.AddWithValue("@spr", textBox4.Text);
            //cmd.Parameters.AddWithValue("@pdate", dateTimePicker1.Value.Date);
            //cmd.Parameters.AddWithValue("@sup", gunaComboBox1.SelectedIndex);
            //cmd.Parameters.AddWithValue("@g", gain);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            supplier2 sup = new supplier2();
            sup.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update supplier set supName=@name,supPhone=@phone,supAdd=@add where supCode=@nic", con);
            cmd.Parameters.AddWithValue("@nic", int.Parse(gunaTextBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            //cmd.Parameters.AddWithValue("@phone", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@add", textBox3.Text);
            //cmd.Parameters.AddWithValue("@spr", textBox4.Text);
            //cmd.Parameters.AddWithValue("@pdate", dateTimePicker1.Value.Date);
            //cmd.Parameters.AddWithValue("@sup", gunaComboBox1.SelectedIndex);
            //cmd.Parameters.AddWithValue("@g", gain);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            supplier2 sup = new supplier2();
            sup.Show();
            this.Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            supplier2 supplier = new supplier2();
            supplier.Show();
            this.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks();
            stocks.Show();
            this.Hide();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            category category = new category();
            category.Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            order order = new order();
            order.Show();
            this.Hide();
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
