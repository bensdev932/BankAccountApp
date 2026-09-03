using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate {  get; set; }

        public SavingsAccount(string owner, decimal interestRate) : base(owner +  "("+interestRate+"%)" )
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount < 10000 || amount > 500000)
            {
                return "Deposit amount must be between 10,000 and 500,000.";
            }

            if (amount + Balance > 500000)
            {
                return "Deposit would exceed the maximum account balance of 500,000.";
            }


            decimal interestAmount = (InterestRate / 100) * amount;

            Balance += amount + interestAmount;
            return "Deposit successful.";

        }

    }
}
