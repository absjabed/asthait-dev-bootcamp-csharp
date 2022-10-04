using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasic
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber, string customerName, double serviceCharge)
            : base(accountNumber, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public CheckingAccount()
        {
        }

        public double ServiceCharge { get; set; }

        public override void Transfer(string from, string to, double amount)
        {
            //todo
        }
    }
}
