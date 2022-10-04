using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sv1 = new SavingsAccount("Jabed","12345",2000);
            sv1.Deposit(150000);
            sv1.Withdraw(5000);
            sv1.Withdraw(5000054654);

            //sv1.CustomerName = "Jabed";
            //sv1.AccountNo = "1545";

            //Console.WriteLine(sv1.CustomerName);
            //Console.WriteLine(sv1.Deposit(150000));
            //Console.WriteLine(sv1.Withdraw(5000));
            //Console.WriteLine(sv1.Withdraw(5000054654));
            Console.WriteLine(sv1.Balance);



            CheckingAccount chk1 = new CheckingAccount("Jamil","2548",3000);
            chk1.Deposit(150000);
            chk1.Withdraw(5000);
            chk1.Withdraw(5000054654);
            //chk1.CustomerName = "Jamil";
            //chk1.AccountNo = "87945";
           
            //Console.WriteLine(chk1.CustomerName);
            //Console.WriteLine(chk1.Deposit(150000));
            //Console.WriteLine( chk1.Withdraw(5000));
            //Console.WriteLine(chk1.Withdraw(5000054654));
            Console.WriteLine(chk1.Balance);

            BankAccount b2 = sv1;
            
            SavingsAccount sv2 = (SavingsAccount) b2;


            BankAccount b3 = chk1;
            b3.Withdraw(5816146114);
            CheckingAccount chk2 = (CheckingAccount) b3;

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
