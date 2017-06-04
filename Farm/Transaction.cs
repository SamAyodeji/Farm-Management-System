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
    public partial class Transaction : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=AYOURDEY-G\AYODEJI;Initial Catalog=FARM.DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        // SqlDataReader dr;

        public Transaction()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
//string constring = @"Data Source=AYOURDEY-G\AYODEJI;Initial Catalog=FARM.DB;Integrated Security=True";
            string Query = "Select * from  farminfo where status = " + 0 + "";
        //    SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(Query, cn);
            SqlDataReader myreader;
            try
            {
                cn.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    int batch = myreader.GetInt32(2);
                    comboBox2.Items.Add(batch);
                }

                myreader.Close();
            }
            catch (Exception)
            {
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "")
            {
                
                cmd.CommandText = "insert into TransDB (type,date,batch_number,mortality,feed,medication_type,medication_amt) VALUES ('" + comboBox1.SelectedItem.ToString() + "','" + dateTimePicker1.Value + "','" + comboBox2.SelectedItem.ToString()+ "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cmd.Clone();

                cmd.CommandText = "update FARMINFO set total_mortality = total_mortality + " + textBox2.Text +", [total_feed(kg)] = [total_feed(kg)] + "+ textBox3.Text +", medication_amt = medication_amt + "+ textBox4.Text +" where batch_number = "+ comboBox2.SelectedItem.ToString() +"";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();
                  
                comboBox1.SelectedText = "";
                comboBox2.SelectedText = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("transaction successful");
               
            }
        }
    }
}
