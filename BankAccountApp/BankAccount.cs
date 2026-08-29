using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner { get; private set; } 
        public Guid AccountNumber { get; set; } 
        public decimal Balance { get; private set; } 


        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0m;
        }

        public string SetOwner(string owner)
        {
            if (string.IsNullOrWhiteSpace(owner))
                return "Owner cannot be empty.";

            foreach (char c in owner)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return "Owner must contain letters and spaces only.";
            }

            Owner = owner;
            return "Owner updated successfully.";
        }


        public string Deposit(decimal amount)
        {
            if (amount < 10000 || amount > 500000)
            {
                return "Deposit amount must be between 10,000 and 500,000.";
            }

            if (amount + Balance > 500000)
            {
                return "Deposit would exceed the maximum account balance of 500,000.";
            }

            Balance += amount;
            return "Deposit successful.";

        }
            

        public string Withdraw(decimal amount)
        {
            if (amount < 10000)
            {
                return "Withdrawal amount must be at least 10,000.";
            }
            
            if (amount > Balance)
            {
                return "Insufficient balance for withdrawal.";
            }

            Balance -= amount;
            return "Withdrawal successful.";    
        }



    }
}