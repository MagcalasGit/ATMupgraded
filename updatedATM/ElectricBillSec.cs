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
    public partial class ElectricBillSec : Form
    {
        private string jsonFilePath = "accountBalances.json";
        private dynamic accountBalances;
        public ElectricBillSec()
        {
            InitializeComponent();
            loadAccountBalances();
            receiptPanel.Visible = false;
        }

        private void ElectricBillSec_Load(object sender, EventArgs e)
        {

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (cheqorsavings.SelectedItem == null)
            {
                MessageBox.Show("Please select Savings or Cheque.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (electricChoice.SelectedItem == null)
            {
                MessageBox.Show("Please select an electric company to pay in.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAccount = cheqorsavings.SelectedItem.ToString();
            string selectedCompany = electricChoice.SelectedItem.ToString();

            if (!decimal.TryParse(txtPayamount.Text, out decimal withdrawAmount))
            {
                MessageBox.Show("Please enter a valid withdrawal amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadAccountBalances();

            if (accountBalances != null && accountBalances.Count > 0)
            {
                bool accountFound = false;

                foreach (var accountBalance in accountBalances)
                {
                    if (accountBalance.ContainsKey(selectedAccount))
                    {
                        decimal currentBalance = accountBalance[selectedAccount];

                        if (withdrawAmount > currentBalance)
                        {
                            MessageBox.Show("Withdrawal amount exceeds available balance.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        accountBalance[selectedAccount] -= withdrawAmount;
                        SaveAccountBalances();
                        LogTransaction(selectedAccount, withdrawAmount, selectedCompany);
                        LoadReceipt();
                        receiptPanel.BringToFront();
                        receiptPanel.Visible = true;

                        accountFound = true;
                        break;
                    }
                }

                if (!accountFound)
                {
                    MessageBox.Show($"{selectedAccount} account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Account balances not found or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LogTransaction(string accountType, decimal amount, string selectedCompany)
        {
            try
            {
                Dictionary<string, decimal> targetDictionary = null;

                foreach (var dictionary in accountBalances)
                {
                    if (dictionary.ContainsKey(accountType))
                    {
                        targetDictionary = dictionary;
                        break;
                    }
                }

                if (targetDictionary != null)
                {
                    Transactions transaction = new Transactions
                    {
                        Account = accountType,
                        Type = $"Paid Electric Bill in {selectedCompany}",
                        Time = DateTime.Now,
                        Amount = amount,
                        Balance = targetDictionary[accountType]
                    };

                    string formattedTime = transaction.Time.ToString("MM/dd/yyyy hh:mm tt");
                    transaction.Time = DateTime.ParseExact(formattedTime, "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);

                    string transactionJson = JsonConvert.SerializeObject(transaction);
                    string transactionsFilePath = "Transactions.json";

                    if (File.Exists(transactionsFilePath))
                    {
                        File.AppendAllText(transactionsFilePath, transactionJson + Environment.NewLine);
                    }
                    else
                    {
                        File.WriteAllText(transactionsFilePath, transactionJson + Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show($"Account '{accountType}' not found in account balances.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadAccountBalances()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonData = File.ReadAllText(jsonFilePath);
                    accountBalances = JsonConvert.DeserializeObject<List<Dictionary<string, decimal>>>(jsonData);
                }
                else
                {
                    accountBalances = new List<Dictionary<string, decimal>>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading account balances: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveAccountBalances()
        {
            string jsonData = JsonConvert.SerializeObject(accountBalances);
            File.WriteAllText("accountBalances.json", jsonData);
        }
        private void ConvertLastTransactionToJsonArray()
        {
            try
            {
                string transactionsFilePath = "Transactions.json";

                if (File.Exists(transactionsFilePath))
                {
                    string[] transactionLines = File.ReadAllLines(transactionsFilePath);

                    if (transactionLines.Length > 0)
                    {
                        List<Transactions> transactionList = new List<Transactions>();

                        foreach (string transactionLine in transactionLines)
                        {
                            Transactions transaction = JsonConvert.DeserializeObject<Transactions>(transactionLine);
                            transactionList.Add(transaction);
                        }

                        string jsonArray = JsonConvert.SerializeObject(transactionList, Formatting.Indented);

                        string outputFilePath = "TransacHistory.json";
                        File.WriteAllText(outputFilePath, jsonArray);
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("No transactions found in the input file.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Transactions input file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting transactions to JSON array: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadReceipt()
        {
            try
            {
                string transactionsFilePath = "Transactions.json";

                if (File.Exists(transactionsFilePath))
                {
                    string[] transactionLines = File.ReadAllLines(transactionsFilePath);

                    if (transactionLines.Length > 0)
                    {
                        string lastTransactionJson = transactionLines[transactionLines.Length - 1];
                        Transactions lastTransaction = JsonConvert.DeserializeObject<Transactions>(lastTransactionJson);
                        ConvertLastTransactionToJsonArray();

                        lblselectedCompany.Text = lastTransaction.Type.Substring(lastTransaction.Type.IndexOf("in ") + 3);
                        lblcheqorsavings.Text = lastTransaction.Account.Contains("Savings") ? "Savings Account" : "Cheque Account";
                        lblAmountSubtracted.Text = lastTransaction.Amount.ToString("N2");
                        lblCurrentBal.Text = lastTransaction.Balance.ToString("N2");
                        lblAccNum.Text = AccountInfo.accountNumber;
                    }
                    else
                    {
                        MessageBox.Show("No transactions found in the input file.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Transactions input file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void receiptPanel_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
