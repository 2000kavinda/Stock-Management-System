using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock_Managemet_System
{
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
            LoadCat();
            LoadSup();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
        private void LoadCat()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from category", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catId", typeof(int));
            dt.Load(rdr);
            comboBox1.ValueMember = "catId";
            comboBox1.DataSource = dt;
            con.Close();
        }
        private void LoadSup()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from supplier", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("supCode", typeof(int));
            dt.Load(rdr);
            gunaComboBox1.ValueMember = "supCode";
            gunaComboBox1.DataSource = dt;
            con.Close();
        }
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int gain = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox3.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into product (prCode,prName,prCategory,prQty,Bprice,Sprice,prDate,SSup,Gain) values(@cd,@pn,@pcat,@pqty,@bpr,@spr,@pdate,@sup,@g)", con);
            cmd.Parameters.AddWithValue("@cd", int.Parse(gunaTextBox1.Text));
            cmd.Parameters.AddWithValue("@pn",textBox1.Text);
            cmd.Parameters.AddWithValue("@pcat", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@pqty", textBox2.Text);
            cmd.Parameters.AddWithValue("@bpr", textBox3.Text);
            cmd.Parameters.AddWithValue("@spr", textBox4.Text);
            cmd.Parameters.AddWithValue("@pdate", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@sup", gunaComboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@g", gain);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            stock2 stock2 = new stock2();
            stock2.Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            int gain = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox3.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update product set prName=@pn,prCategory=@pcat,prQty=@pqty,Bprice=@bpr,Sprice=@spr,prDate=@pdate,SSup=@sup,Gain=@g where prCode=@cd", con);
            cmd.Parameters.AddWithValue("@cd", int.Parse(gunaTextBox1.Text));
            cmd.Parameters.AddWithValue("@pn", textBox1.Text);
            cmd.Parameters.AddWithValue("@pcat", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@pqty", textBox2.Text);
            cmd.Parameters.AddWithValue("@bpr", textBox3.Text);
            cmd.Parameters.AddWithValue("@spr", textBox4.Text);
            cmd.Parameters.AddWithValue("@pdate", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@sup", gunaComboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@g", gain);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            stock2 stock2 = new stock2();
            stock2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            stock2 stock2 = new stock2();
            stock2.Show();
            this.Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier(); 
            supplier.Show();
            this.Hide();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            category category = new category();
            category.Show();
            this.Hide();
        }

        private void gunaButton6_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

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
