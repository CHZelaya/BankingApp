using BankClasses;

namespace BankingGui
{
    public partial class Form1 : Form
    {

        // List of accounts
        List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Account account1 = ;
            accounts.Add(new Account(100));
            accounts.Add(new Account(-20));
            accounts.Add(new Account(200));
            DisplayAccounts();
        }

        private void DisplayAccounts()
        {
            ListAccounts.Items.Clear();
            foreach (Account account in accounts)
            {
                ListAccounts.Items.Add(account);
            }
        }

        private void Button_Deposit_Click(object sender, EventArgs e)
        {
            // Ensure that an account is selected form the list of accounts
            if (ListAccounts.SelectedIndex == -1) // If no account is selected
            {
                MessageBox.Show("Please select an account");
                ListAccounts.Focus();
            }
            else //If an account is selected
            {
                Account accountSelected = accounts[ListAccounts.SelectedIndex];
                accountSelected.Desposit(Convert.ToDouble(TextBox_Amount.Text));
            }
        }
    }
}
