using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Farm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection( @"Data Source=AYOURDEY-G\AYODEJI;Initial Catalog=FARM.DB;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Logindb where USERNAME = '"+ textBox1.Text +"' and PASSWORD = '"+ textBox2.Text +"'", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
                while (dr.Read())
            {
              count += 1;
            }
            if (count == 1)
            
            {
                MenuPage f2 = new MenuPage();
                f2.Show();
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate username and password", "login page");
            }
            else
            {
                MessageBox.Show(" Incorrect username or password", "login page");
            }

            {

            }

            }
    }
}
    


    

