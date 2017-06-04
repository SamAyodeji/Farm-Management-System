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
    public partial class Signup : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=AYOURDEY-G\AYODEJI;Initial Catalog=FARM.DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "")
            {
                cn.Open();
                cmd.CommandText = "insert into Logindb ([Full name],username,password,[Re-type_password]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
               MessageBox.Show("User created successfully");
                {
                   
                   
                }

            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
