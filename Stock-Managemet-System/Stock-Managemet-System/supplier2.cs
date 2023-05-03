﻿using System;
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
    public partial class supplier2 : Form
    {
        public supplier2()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from supplier", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            //MessageBox.Show("sucess");
            con.Close();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier();
            supplier.Show();
            this.Hide();
        }

        private void supplier2_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier();
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

        private void gunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BN60TVJ2\SQLEXPRESS;Initial Catalog=stock-management-system;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete supplier where supCode=@nic", con);
            cmd.Parameters.AddWithValue("@nic", int.Parse(gunaTextBox1.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
            refresh();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            category category = new category();
            category.Show();
            this.Hide();
        }
    }
}
