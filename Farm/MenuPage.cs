using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Farm
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup f2 = new Signup();
            f2.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBatch f2 = new NewBatch();
            f2.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closeBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close f4 = new Close();
            f4.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPage f3 = new MenuPage();
            this.Close();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction f7 = new Transaction();
            f7.ShowDialog();

        }

        private void reopenBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReOpen f8 = new ReOpen();
            f8.ShowDialog();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report F9 = new Report();
            F9.ShowDialog(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an Administrative software to monitor the monthly transactions of a pultry and fishry farming to know how profitable the investment is,for any software issues contact us @ JIREH IT CONSULTANTS(08137951647,08023037488) thank you");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBatch f2 = new NewBatch();
            f2.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction f7 = new Transaction();
            f7.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report F9 = new Report();
            F9.ShowDialog(); 
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report F9 = new Report();
            F9.ShowDialog(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPage f3 = new MenuPage();
            this.Close();
        }
    }
}
