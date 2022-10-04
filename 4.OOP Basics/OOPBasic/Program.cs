using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Kazi", "Mizanul", "Hoq");

            //person1.firstName = "Kazi";
            //person1.middleName = "Mizanul";
            //person1.lastName = "Hoq";
            

            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);


            Person person2 = new Person("Jamil", "Hossain", "Magnessiam");

            //person2.firstName = "Jamil";
            //person2.middleName = "Hossain";
            //person2.lastName = "Magnessiam";


            Person person3;
            Person person4;
            Person person5;

            person3 = person1;
            person4 = person1;
            person4 = null;
            person5 = person3;



            person5.firstName = "Shihab";
            person3.lastName = "Rahman";

            Change(person1);
            fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.ReadKey();
        }

        private static void Change(Person aperson)
        {
            aperson.firstName = string.Empty;
        }
    }
}
