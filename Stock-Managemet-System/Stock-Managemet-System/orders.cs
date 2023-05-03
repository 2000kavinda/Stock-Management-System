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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
            LoadCus();
            Loadproducts();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
        private void LoadCus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nic", typeof(int));
            dt.Load(rdr);
            gunaComboBox1.ValueMember = "nic";
            gunaComboBox1.DataSource = dt;
            con.Close();
        }
        private void Loadproducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from product", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("prCode", typeof(int));
            dt.Load(rdr);
            gunaComboBox3.ValueMember = "prCode";
            gunaComboBox3.DataSource = dt;
            con.Close();
        }


        private void orders_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
