using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasicApp
{
    class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }


        public BankAccount(string accountNo, string customerName):this()
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }

        public BankAccount()
        {
            Balance = 0;
        }

        public string Deposit(double amount)
        {
            Balance += amount;
            
            return "Deposit successfull.";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw successful.";
        }
    }
}
