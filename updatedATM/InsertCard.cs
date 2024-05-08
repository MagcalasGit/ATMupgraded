using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updatedATM
{
    public partial class InsertCard : Form
    {
        public InsertCard()
        {
            InitializeComponent();
            PnlInsertCard.Visible = true;
        }

        private void InsertCard_Load(object sender, EventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "0";
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "1";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "3";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "4";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "9";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text += "2";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtInsertCard.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (txtInsertCard.Text.Length > 0)
            {
                txtInsertCard.Text = txtInsertCard.Text.Substring(0, txtInsertCard.Text.Length - 1);
            }
        }

        private void btninsertCard_Click(object sender, EventArgs e)
        {
            if (txtInsertCard.Text == "0000")
            {
                Form1 gotoForm = new Form1();
                this.Hide();
                gotoForm.Show();
            }
            else
            {
                MessageBox.Show("Please Enter 0000.");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
