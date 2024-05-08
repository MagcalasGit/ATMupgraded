using atmsystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updatedATM
{
    public partial class WaterBillSec : Form
    {
        private dynamic accountBalances;
        public WaterBillSec()
        {
            InitializeComponent();
            receiptPanel.Visible = false;
        }

        private void WaterBillSec_Load(object sender, EventArgs e)
        {

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (cheqorsavings.SelectedItem == null)
            {
                MessageBox.Show("Please select Savings or Cheque.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAccount = cheqorsavings.SelectedItem.ToString();

            if (waterChoice.SelectedItem == null)
            {
                MessageBox.Show("Please select which Company to pay your Electric Bills", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCompany = waterChoice.SelectedItem.ToString();

            if (!decimal.TryParse(txtPayamount.Text, out decimal paymentAmount))
            {
                MessageBox.Show("Please enter a valid payment amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal currentBalance = selectedAccount == "Savings" ? AccountManager.SavingsBalance : AccountManager.ChequeBalance;

            if (paymentAmount > currentBalance)
            {
                MessageBox.Show("Insufficient Balance");
                return;
            }
            if (selectedAccount == "Savings")
            {
                AccountManager.SavingsBalance -= paymentAmount;
                MessageBox.Show($"Payment amount of ₱{paymentAmount:N2} into Savings account successful.", "Withdraw Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedAccount == "Cheque")
            {
                AccountManager.ChequeBalance -= paymentAmount;
                MessageBox.Show($"Payment amount of ₱{paymentAmount:N2} into Cheque account successful.", "Wtihdraw Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadReceipt();
            SaveAccountBalances(selectedAccount, paymentAmount);
            receiptPanel.BringToFront();
            receiptPanel.Visible = true;
        }
        //functions
        private void loadAccountBalances()
        {
           
        }
        private void SaveAccountBalances(string selectedAccount, decimal amount)
        {
            DateTime dateTime = DateTime.Now;

            string accountJson = File.ReadAllText("accountBalances.json");
            List<AccountInfo> accounts = JsonConvert.DeserializeObject<List<AccountInfo>>(accountJson);
            var account = accounts.FirstOrDefault(acc => acc.AccountNumber == AccountManager.AccountNumber);
            if (account != null)
            {
                account.SavingsBalance = AccountManager.SavingsBalance;
                account.ChequeBalance = AccountManager.ChequeBalance;
                string updatedAccountJson = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                File.WriteAllText("accountBalances.json", updatedAccountJson);
            }
            string selectedCompany = waterChoice.SelectedItem.ToString();
            var transaction = new
            {
                Username = AccountManager.AccountNumber,
                Type = $"Payment in {selectedCompany}",
                Account = selectedAccount,
                DateTime = dateTime.ToString("yyyy-MM-dd HH:mm"),
                Amount = amount,
                Balance = selectedAccount == "Savings" ? AccountManager.SavingsBalance : AccountManager.ChequeBalance
            };

            string transactionsFile = "transactions.json";
            string transactionJson = JsonConvert.SerializeObject(transaction);
            File.AppendAllText(transactionsFile, transactionJson + Environment.NewLine);
            ConvertToJSON();
        }
        private void ConvertToJSON()
        {
            string transactionsFile = "transactions.json";
            string[] lines = File.ReadAllLines(transactionsFile);

            if (lines.Length == 0)
            {
                MessageBox.Show("No transactions found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lastTransactionJson = lines[lines.Length - 1];
            dynamic lastTransaction = JsonConvert.DeserializeObject(lastTransactionJson);

            decimal balance = lastTransaction.Account == "Savings" ? AccountManager.SavingsBalance : AccountManager.ChequeBalance;

            string selectedCompany = waterChoice.SelectedItem.ToString();
            var formattedTransaction = new
            {
                Username = AccountManager.AccountNumber,
                Type = $"Payment in {selectedCompany}",
                Account = lastTransaction.Account,
                DateTime = lastTransaction.DateTime,
                Amount = lastTransaction.Amount,
                Balance = balance
            };

            string transactionHistoryFile = "transactionHistory.json";
            string transactionHistoryJson = File.Exists(transactionHistoryFile) ? File.ReadAllText(transactionHistoryFile) : "[]";
            List<dynamic> transactionHistory = JsonConvert.DeserializeObject<List<dynamic>>(transactionHistoryJson);
            transactionHistory.Add(formattedTransaction);

            string updatedTransactionHistoryJson = JsonConvert.SerializeObject(transactionHistory);
            File.WriteAllText(transactionHistoryFile, updatedTransactionHistoryJson);
        }
        private void LoadReceipt()
        {
            string selectedCompany = waterChoice.SelectedItem.ToString();
            string selectedType = cheqorsavings.SelectedItem.ToString();
            decimal withdrawalAmount = decimal.Parse(txtPayamount.Text);

            lblselectedCompany.Text = selectedCompany;

            lblcheqorsavings.Text = selectedType;

            lblAccNum.Text = AccountManager.AccountNumber;

            lblAmountSubtracted.Text = withdrawalAmount.ToString("C", new CultureInfo("en-PH"));

            decimal currentBalance = selectedType == "Savings" ? AccountManager.SavingsBalance : AccountManager.ChequeBalance;
            lblCurrentBal.Text = currentBalance.ToString("C", new CultureInfo("en-PH"));
            receiptPanel.BringToFront();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            MainForm goBack = new MainForm();
            this.Hide();
            goBack.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MainForm goBack = new MainForm();
            this.Hide();
            goBack.Show();
        }

        private void receiptPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
