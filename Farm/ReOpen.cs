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
    public partial class ReOpen : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=AYOURDEY-G\AYODEJI;Initial Catalog=FARM.DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        // SqlDataReader dr;
        public ReOpen()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
             //string constring = @"Data Source=AYOURDEY-G\AYODEJI;Initial Catalog=FARM.DB;Integrated Security=True";
            string Query = "Select * from farminfo where status =" + 1 + "";
           // SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(Query, cn);
            SqlDataReader myreader;
            try
            {
                cn.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    int batch = myreader.GetInt32(2);
                    comboBox1.Items.Add(batch);

                }

                myreader.Close();
            }
            catch (Exception)
            {
                cn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqls = "update farminfo set status = '0' where batch_number ='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.CommandText = sqls;
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Batch RE-opened");
             comboBox1.SelectedItem = "";
        }
    }
}
