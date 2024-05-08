using atmsystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace updatedATM
{
    public partial class MainForm : Form
    {
        private const string transactionsFilePath = "TransacHistory.json";
        public MainForm()
        {
            InitializeComponent();
            TransactionPanel.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            checkBalanceSection gotoChB = new checkBalanceSection();
            this.Hide();
            gotoChB.Show();
        }

        private void transactionsBtn_Click(object sender, EventArgs e)
        {
            TransactionPanel.Visible = true;
            LoadTransactionHistory();
        }
        //functions
        private void LoadTransactionHistory()
        {
            string transactionHistoryFile = "transactionHistory.json";
            string transactionHistoryJson = File.Exists(transactionHistoryFile) ? File.ReadAllText(transactionHistoryFile) : "[]";
            List<dynamic> transactionHistory = JsonConvert.DeserializeObject<List<dynamic>>(transactionHistoryJson);

            var userTransactions = transactionHistory
                .Where(t => t.Username == AccountManager.AccountNumber)
                .Select(t => new
                {
                    Type = t.Type,
                    Account = t.Account,
                    DateTime = t.DateTime,
                    Amount = t.Amount,
                    Balance = t.Balance
                });
            dgvTransaction.DataSource = userTransactions.ToList();
        }

        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            InsertCard goback = new InsertCard();
            this.Hide();
            goback.Show();
        }

        private void wtihdrawBtn_Click(object sender, EventArgs e)
        {
            withdrawsection gotoWithdraw = new withdrawsection();
            this.Hide();
            gotoWithdraw.Show();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            depositsection gotoDeposit = new depositsection();
            this.Hide();
            gotoDeposit.Show();
        }

        private void paybillsBtn_Click(object sender, EventArgs e)
        {
            paybillssection gotoPaybills = new paybillssection();
            this.Hide();
            gotoPaybills.Show();
        }

        private void hideTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionPanel.Visible = false;
        }

        private void TransactionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 gotoForm = new Form1();
            this.Hide();
            gotoForm.Show();
        }
    }
}
