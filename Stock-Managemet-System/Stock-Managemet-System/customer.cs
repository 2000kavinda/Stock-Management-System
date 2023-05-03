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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //int gain = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox3.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customer (nic,cusName,cusPhone,cusAdd,cusGen) values(@nic,@name,@phone,@add,@gen)", con);
            cmd.Parameters.AddWithValue("@nic", int.Parse(gunaTextBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@gen", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@add", textBox3.Text);
            //cmd.Parameters.AddWithValue("@spr", textBox4.Text);
            //cmd.Parameters.AddWithValue("@pdate", dateTimePicker1.Value.Date);
            //cmd.Parameters.AddWithValue("@sup", gunaComboBox1.SelectedIndex);
            //cmd.Parameters.AddWithValue("@g", gain);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            customer2 cus= new customer2();
            cus.Show();
            this.Hide();
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks();
            stocks.Show();
            this.Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            customer2 cus = new customer2();
            cus.Show();
            this.Hide();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //int gain = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox3.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update customer set cusName=@name,cusPhone=@phone,cusAdd=@add,cusGen=@gen where nic=@nic", con);
            cmd.Parameters.AddWithValue("@nic", int.Parse(gunaTextBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@gen", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@add", textBox3.Text);
            //cmd.Parameters.AddWithValue("@spr", textBox4.Text);
            //cmd.Parameters.AddWithValue("@pdate", dateTimePicker1.Value.Date);
            //cmd.Parameters.AddWithValue("@sup", gunaComboBox1.SelectedIndex);
            //cmd.Parameters.AddWithValue("@g", gain);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            customer2 cus2 = new customer2();
            cus2.Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            customer2 cus = new customer2();
            cus.Show();
            this.Hide();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier();
            supplier.Show();
            this.Hide();
        }
    }
}
