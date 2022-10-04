using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasic
{
    class SavingsAccount : BankAccount
    {
        //public SavingsAccount()
        //{

        //}

        public SavingsAccount(string accountNumber, string customerName, double interestAmount)
            : base(accountNumber, customerName)
        {
            InterestAmount = interestAmount;
        }

        public SavingsAccount()
        {
        }

        public double InterestAmount { get; set; }

        public override string Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return "Insufficient balance.";
            }
            return base.Withdraw(amount);
        }

        public override void Transfer(string from, string to, double amount)
        {
            //todo
        }
    }
}
