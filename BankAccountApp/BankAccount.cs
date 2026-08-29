using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner { get; set; } 
        public Guid AccountNumber { get; set; } 
        public decimal Balance { get; private set; } 


        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0m;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 1000 || amount >= 500000)
            {
                throw new ArgumentException("Deposit amount must be between 1000 and 500000");
            }

            if (Balance + amount > 500000)
            {
                throw new ArgumentException("Deposit amount would exceed the maximum balance.");
            }

            Balance += amount;
        }


        public void Withdraw(decimal amount)
        {
            if (amount < 1000 || amount > 100000)
            {
                throw new ArgumentException("Withdrawal amount must be between ₱1,000.00 and ₱100,000.00.");
            }

            if (amount > Balance )
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;

        }



    }
}
