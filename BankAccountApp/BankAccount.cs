using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner { get; set; } 
        public Guid AccountNumber { get; set; } 
        public decimal Balance { get; set; } 


        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0m;
        }

    }
}
