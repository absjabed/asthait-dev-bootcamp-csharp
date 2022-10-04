using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicPrivateProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();


            person1.FirstName = "Kazi";
            person1.MiddleName = "Mizanul";
            person1.LastName = "Hoq";

            //person1.SetFirstName("Kazi");
            //person1.SetMiddleName("Mizanul");
            //person1.SetLastName("Hoq");

            //person1.firstName = "Kazi";
            //person1.middleName = "Mizanul";
            //person1.lastName = "Hoq";


            string fullName = person1.FullName;
            string reverseName = person1.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.ReadKey();

            // Person person2 = new Person("Jamil", "Hossain", "Magnessiam");

            //person2.firstName = "Jamil";
            //person2.middleName = "Hossain";
            //person2.lastName = "Magnessiam";


        }
    }
}
