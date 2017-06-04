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
    public partial class NewBatch : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=AYOURDEY-G\AYODEJI;Initial Catalog=FARM.DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
      

        public NewBatch()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "")
            {
                cn.Open();
                cmd.CommandText = "insert into FARMINFO (type,batch_number,number_collected,age_collected,total_mortality,[total_feed(kg)],medication_amt,[DATE_COLLECT]) VALUES ('" + comboBox1.SelectedItem + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Value + "')";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                MessageBox.Show("registered successfully");
               
            }

        }

        private void textBox7_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label9_Click(object sender, System.EventArgs e)
        {

        }

        private void label8_Click(object sender, System.EventArgs e)
        {

        }

        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void NewBatch_Load(object sender, EventArgs e)
        {

        }
    }
}
