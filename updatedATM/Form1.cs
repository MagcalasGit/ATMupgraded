using atmsystem;
using Guna.UI2.WinForms;
using Newtonsoft;
using Newtonsoft.Json;

namespace updatedATM
{
    public partial class Form1 : Form
    {
        private int loginAttempts = 0;
        private const int maxAttempts = 3;
        public Form1()
        {
            InitializeComponent();
            txtPIN.UseSystemPasswordChar = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked == true)
            {
                txtPIN.UseSystemPasswordChar = false;
            }
            else
            {
                txtPIN.UseSystemPasswordChar = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginAttempts++;

            if (loginAttempts > maxAttempts)
            {
                MessageBox.Show("Maximum login attempts exceeded. Account Disabled.");
                return;
            }

            string json = File.ReadAllText("accountBalances.json");
            List<AccountInfo> accounts = JsonConvert.DeserializeObject<List<AccountInfo>>(json);

            var account = accounts.FirstOrDefault(acc => acc.AccountNumber == txtCardNum.Text && acc.PIN == txtPIN.Text);
            if (account != null)
            {
                AccountManager.SetAccountNumber(txtCardNum.Text);
                AccountManager.PIN = txtPIN.Text;
                AccountManager.SavingsBalance = account.SavingsBalance;
                AccountManager.ChequeBalance = account.ChequeBalance;

                MainForm gotoMain = new MainForm();
                this.Hide();
                gotoMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Account Number or PIN. Attempts left: " + (maxAttempts - loginAttempts));
                txtCardNum.Text = "";
                txtPIN.Text = "";
                if (loginAttempts == maxAttempts)
                {
                    MessageBox.Show("Maximum login attempts reached. Closing program.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInsertCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string accountNumber = txtCardNum.Text;
            string pin = txtPIN.Text;

            RegisterUser(accountNumber, pin);
        }

        private void RegisterUser(string accountNumber, string pin)
        {
            string json = File.ReadAllText("accountBalances.json");
            List<AccountInfo> accounts = JsonConvert.DeserializeObject<List<AccountInfo>>(json);

            if (accounts.Any(acc => acc.AccountNumber == accountNumber))
            {
                MessageBox.Show("Account Number already registered.");
                return;
            }

            AccountInfo newAccount = new AccountInfo
            {
                AccountNumber = accountNumber,
                PIN = pin,
                SavingsBalance = 100000,
                ChequeBalance = 100000
            };
            accounts.Add(newAccount);
            string updatedJson = JsonConvert.SerializeObject(accounts, Formatting.Indented);
            File.WriteAllText("accountBalances.json", updatedJson);

            MessageBox.Show("Account registered successfully.");
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (txtPIN.Focused)
            {
                txtPIN.Text += "0";
            }
            else
            {
                txtPIN.Text += "0";
                txtCardNum.Text += "0";
            }
        }

        
    }
    public class AccountInfo
    {
        public string AccountNumber { get; set; }
        public string PIN { get; set; }
        public decimal SavingsBalance { get; set; }
        public decimal ChequeBalance { get; set; }
    }
}
