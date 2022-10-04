using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasicApp
{
    class SavingsAccount : BankAccount
    {
        public double InterestAmount { get; set; }


        public SavingsAccount(string accountNo, string customerName, double interestAmount) 
            : base(accountNo, customerName)
        {
            InterestAmount = interestAmount;
        }

        public SavingsAccount()
        {
        }

        public override string Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return "Insufficiant Balance.";

            }
            return base.Withdraw(amount);
        }
    }
}
