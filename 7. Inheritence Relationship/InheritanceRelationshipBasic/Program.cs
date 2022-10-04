using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sv1 = new SavingsAccount("SV-009", "Reaz", 3000);
            sv1.Deposit(26300);
            sv1.Withdraw(2500);

            CheckingAccount chk1 = new CheckingAccount("CHK-012", "Musa Bin", 15000);
            chk1.Deposit(26314500);
            chk1.Withdraw(9654200);
            chk1.Withdraw(965420000);


            //BankAccount b1 = new BankAccount();

            BankAccount b2 = sv1;

            SavingsAccount sv2 = (SavingsAccount)b2;


            //double d = sv2.InterestAmount;


            BankAccount b3 = chk1;
            b3.Withdraw(8523000);

            //CheckingAccount ck2 = (CheckingAccount)b3;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(sv1);
            bankAccounts.Add(chk1);

            foreach (BankAccount bankAccount in bankAccounts)
            {
                bankAccount.Withdraw(1000);
            }

            Console.ReadKey();
        }
    }
}
