using System;
using System.ComponentModel; 
using System.Windows.Forms;

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

            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Please enter an account owner.");
                return;
            }

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            BankAccounts.Add(bankAccount);

            MessageBox.Show($"Account created for {bankAccount.Owner}");

            RefreshDataGrid();
            OwnerTxt.Clear();

        }


        private void RefreshDataGrid()
        {
            BanksAccountDataGrid.DataSource = null;
            BanksAccountDataGrid.DataSource = BankAccounts;
        }   

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            
        }

        

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
