using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Managemet_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text=="adm") 
            {
                Stocks stocks = new Stocks();
                stocks.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
