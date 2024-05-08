using atmsystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace updatedATM
{
    public partial class depositsection : Form
    {
        public depositsection()
        {
            InitializeComponent();
            loadAccountBalances();
            receiptPanel.Visible = false;
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (cbxsaviOrCheq.SelectedItem == null)
            {
                MessageBox.Show("Please select Savings or Cheque.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAccount = cbxsaviOrCheq.SelectedItem.ToString();

            if (!decimal.TryParse(txtDepositAmount.Text, out decimal depositAmount))
            {
                MessageBox.Show("Please enter a valid deposit amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<int, int> billDispenseResult = DispenseBills((double)depositAmount);

            if (billDispenseResult != null)
            {
                // Deposit successful
                if (selectedAccount == "Savings")
                {
                    AccountManager.SavingsBalance += depositAmount;
                    MessageBox.Show($"Deposit of ₱{depositAmount:N2} into Savings account successful.", "Deposit Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedAccount == "Cheque")
                {
                    AccountManager.ChequeBalance += depositAmount;
                    MessageBox.Show($"Deposit of ₱{depositAmount:N2} into Cheque account successful.", "Deposit Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadReceipt();
                SaveAccountBalances(selectedAccount, depositAmount);
                receiptPanel.BringToFront();
                receiptPanel.Visible = true;
            }
            else
            {

                MessageBox.Show("Coins cannot be deposited. Please deposit whole amounts only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

            var transaction = new
            {
                Username = AccountManager.AccountNumber,
                Type = "Deposit",
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

        private Dictionary<int, int> DispenseBills(double withdrawalAmount)
        {
            int[] availableBills = {20};
            Dictionary<int, int> billCounts = new Dictionary<int, int>();
            double remainingAmount = withdrawalAmount;

            foreach (int billValue in availableBills)
            {
                if (remainingAmount <= 0)
                    break;

                if (billValue > remainingAmount)
                    continue;

                int billCount = (int)(remainingAmount / billValue);

                if (billCount > 0)
                {
                    billCounts.Add(billValue, billCount);
                    remainingAmount -= billCount * billValue;
                }
            }

            const double epsilon = 0.01;
            if (Math.Abs(remainingAmount) < epsilon)
                return billCounts;
            else
                return null;
        }

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDepositAmount.Text, out decimal depositAmount))
            {
                txtDepositAmount.Text = "";
                return;
            }

            if (depositAmount > 20000)
            {
                MessageBox.Show("Maximum deposit amount is ₱20,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepositAmount.Text = "20000";
            }
        }

        private void receiptPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LoadReceipt()
        {
            string selectedType = cbxsaviOrCheq.SelectedItem.ToString();
            decimal depositAmount = decimal.Parse(txtDepositAmount.Text);

            lblAccountNum.Text = selectedType;

            lblAccNum.Text = AccountManager.AccountNumber;

            lblAmountAdd.Text = depositAmount.ToString("C", new CultureInfo("en-PH"));

            decimal currentBalance = selectedType == "Savings" ? AccountManager.SavingsBalance : AccountManager.ChequeBalance;
            lblCurrentBal.Text = currentBalance.ToString("C", new CultureInfo("en-PH"));
            receiptPanel.BringToFront();
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

            var formattedTransaction = new
            {
                Username = AccountManager.AccountNumber,
                Type = "Deposit",
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

        private void continueBtn_Click(object sender, EventArgs e)
        {
            MainForm goback = new MainForm();
            this.Hide();
            goback.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MainForm goBack = new MainForm();
            this.Hide();
            goBack.Show();
        }
    }
    
}
