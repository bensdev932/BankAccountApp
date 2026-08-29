using System;
using System.ComponentModel; 
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Imaging.Effects;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {

        List<BankAccount> BankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);

            string result = bankAccount.SetOwner(OwnerTxt.Text);

            if (result != "Owner updated successfully.")
            {
                MessageBox.Show(result);
                return;
            }

            BankAccounts.Add(bankAccount);

            MessageBox.Show($"Account created for {bankAccount.Owner}");

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            BanksAccountDataGrid.DataSource = null;
            BanksAccountDataGrid.DataSource = BankAccounts;

            if (BanksAccountDataGrid.Columns["Balance"] != null)
            {
                BanksAccountDataGrid.Columns["Balance"].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("fil-PH");
                BanksAccountDataGrid.Columns["Balance"].DefaultCellStyle.Format = "C2"; 
            }
           
            OwnerTxt.Clear();
            AmountNum.Value = 0m;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
           if (BanksAccountDataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            BankAccount selectedAccount = BanksAccountDataGrid.SelectedRows[0].DataBoundItem as BankAccount;


            if (selectedAccount == null)
            {
                MessageBox.Show("Unable to find the selected account.");
                return;
            }

            string message =
                selectedAccount.Deposit(AmountNum.Value);

            RefreshDataGrid();
            MessageBox.Show(message);
        }
     

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BanksAccountDataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select an account");
                return;
            }

            BankAccount selectedAccount = BanksAccountDataGrid.SelectedRows[0].DataBoundItem as BankAccount;

            if (selectedAccount == null)
            {
                MessageBox.Show("Unable to find the selected account.");
                return;
            }

            string message = selectedAccount.Withdraw(AmountNum.Value);
            RefreshDataGrid(); 
            MessageBox.Show(message);
        }
          

       
    }
}
