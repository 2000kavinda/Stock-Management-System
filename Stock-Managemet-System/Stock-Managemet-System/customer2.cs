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

namespace Stock_Managemet_System
{
    public partial class customer2 : Form
    {
        public customer2()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            //MessageBox.Show("sucess");
            con.Close();
        }

        private void customer2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            //MessageBox.Show("sucess");
            con.Close();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks();   
            stocks.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete customer where nic=@nic", con);
            cmd.Parameters.AddWithValue("@nic", int.Parse(gunaTextBox1.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            refresh();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier(); 
            supplier.Show();
            this.Hide();
        }
    }
}
