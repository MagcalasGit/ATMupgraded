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
            try
            {
                string jsonFilePath = "accountBalances.json";
                string jsonData = File.ReadAllText(jsonFilePath);

                List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(jsonData);

                if (accounts.Count > 0)
                {
                    Account firstAccount = accounts[0];

                    lblSavingsbalance.Text = $"₱{firstAccount.Savings.ToString()}";
                    lblChequebalance.Text = $"₱{firstAccount.Cheque.ToString()}";
                }
                else
                {
                    MessageBox.Show("No account balances found in the file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading account balances: {ex.Message}");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MainForm goBack = new MainForm();
            this.Hide();
            goBack.Show();
        }
    }
    public class Account
    {
        public double Savings { get; set; }
        public double Cheque { get; set; }
    }
}
