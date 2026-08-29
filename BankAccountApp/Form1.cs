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
            AmountNum.Minimum = 0m;
            AmountNum.Maximum= 500000m;
            AmountNum.DecimalPlaces = 2;

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Please enter an account owner.");
                return;
            }

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
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
            // Make sure an account is selected.

            if (BanksAccountDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select account first.");
                return;
            }


            // Get the selected account.
            BankAccount selectedAccount =
                 BanksAccountDataGrid.CurrentRow.DataBoundItem as BankAccount;

            if(selectedAccount == null)
            {
                MessageBox.Show("Unable to find selected account.");
                return;
            }

            // Get the amount from NumericUpDown.

            decimal amount = AmountNum.Value;


            // Validate amount.
            if (amount < 1000 || amount > 500000)
            {
                MessageBox.Show("Please enter valid amount with minimum of 1000 and maximum of 500000");
                return;
            }

            // Deposit the money.
            
           try 
            {
                selectedAccount.Deposit(amount);
                MessageBox.Show($"Successfully deposited {amount.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))} into {selectedAccount.Owner}'s account.");
                RefreshDataGrid(); 

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void WithdrawBtn_Click(object sender, EventArgs e)
        {

            // Make sure an account is selected.
            if (BanksAccountDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Select Account first");
                return;
            }


            // Get the selected account.
            BankAccount selectedAccount =
                BanksAccountDataGrid.CurrentRow.DataBoundItem as BankAccount;


           
            if (selectedAccount == null)
            {
                MessageBox.Show("Unable to find account");
                return;

            }


            // Get the amount from NumericUpDown.
            decimal amount = AmountNum.Value;

            // Validate amount.

            if (amount < 1000 || amount > 100000)
            {
                MessageBox.Show("Please enter valid amount.");
                return;
            }

            // Withdraw the money.


            try
            {
                selectedAccount.Withdraw(amount);
                MessageBox.Show($"Successfully withdrew {amount.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))} from {selectedAccount.Owner}'s account.");

                // Refresh the DataGridView.
                RefreshDataGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
