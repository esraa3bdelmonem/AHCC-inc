using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class BankAccount
    {
        private decimal balance;

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
          
            balance -= amount;
        }

        public void ResetBalance()
        {
            balance = 0;
        }
    }

}
