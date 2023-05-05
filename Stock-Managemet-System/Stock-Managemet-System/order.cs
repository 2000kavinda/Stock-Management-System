using Guna.UI.WinForms;
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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [order]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            //MessageBox.Show("sucess");
            con.Close();
        }
        private void check()
        {
            int gain = Convert.ToInt32(gunaTextBox3.Text) * Convert.ToInt32(gunaTextBox7.Text);
            gunaTextBox6.Text = gain.ToString();
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from product where prName=@name", con);
            cmd.Parameters.AddWithValue("@name", gunaTextBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            //MessageBox.Show("sucess");
            con.Close();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //int gain = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox3.Text);
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [order] (oNum,prCode,nic,price,qty) values(@oNum,@prCode,@nic,@price,@qty)", con);
            cmd.Parameters.AddWithValue("@oNum", gunaTextBox5.Text);
            cmd.Parameters.AddWithValue("@prCode", gunaTextBox2.Text);
            cmd.Parameters.AddWithValue("@nic", gunaTextBox4.Text);
            cmd.Parameters.AddWithValue("@price", gunaTextBox3.Text);
            cmd.Parameters.AddWithValue("@qty", gunaTextBox7.Text);
            //cmd.Parameters.AddWithValue("@pn", textBox1.Text);
            //cmd.Parameters.AddWithValue("@pcat", comboBox1.SelectedValue.ToString());
            //cmd.Parameters.AddWithValue("@pqty", textBox2.Text);
            //cmd.Parameters.AddWithValue("@bpr", textBox3.Text);
            //cmd.Parameters.AddWithValue("@spr", textBox4.Text);
            //cmd.Parameters.AddWithValue("@pdate", dateTimePicker1.Value.Date);
            //cmd.Parameters.AddWithValue("@sup", gunaComboBox1.SelectedValue.ToString());
            //cmd.Parameters.AddWithValue("@g", gain);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            refresh();
            check();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete [order] where oNum=@oNum", con);
            cmd.Parameters.AddWithValue("@oNum", int.Parse(gunaTextBox5.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            refresh();
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {

        }
    }
}
