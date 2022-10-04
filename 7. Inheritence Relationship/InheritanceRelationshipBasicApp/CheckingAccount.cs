using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasicApp
{
    class CheckingAccount : BankAccount
    {
        public double ServiceCharge { get; set; }

        public CheckingAccount(string accountNo, string customerName, double serviceCharge) 
            : base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public CheckingAccount()
        {
        }
    }
}
