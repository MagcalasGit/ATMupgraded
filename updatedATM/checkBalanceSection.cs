using atmsystem;
using Newtonsoft.Json;
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
    public partial class checkBalanceSection : Form
    {
        public checkBalanceSection()
        {
            InitializeComponent();
        }

        private void checkBalanceSection_Load(object sender, EventArgs e)
        {
            lblSavingsbalance.Text = "₱" + AccountManager.SavingsBalance.ToString("#,##0.00");
            lblChequebalance.Text = "₱" + AccountManager.ChequeBalance.ToString("#,##0.00");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MainForm goBack = new MainForm();
            this.Hide();
            goBack.Show();
        }
    }
}
