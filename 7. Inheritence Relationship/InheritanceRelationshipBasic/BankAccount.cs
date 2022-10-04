using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasic
{
    abstract class BankAccount
    {
        public BankAccount(string accountNumber, string customerName)
            : this()
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
        }

        public BankAccount()
        {
            Balance = 0;
        }

        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit successful.";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw successful.";
        }

        public abstract void Transfer(string from, string to, double amount);
    }
}
