using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicAssociativeRelationshipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Address personAddress = new Address();
            personAddress.HouseNo = "35A";
            personAddress.RoadNo = "3";
            personAddress.PostCode = "4000";
            personAddress.Area = "Golpahar";
            personAddress.Thana = "Panchlaish";

            Person person1 = new Person();

            person1.FirstName = "Kazi";
            person1.MiddleName = "Mizanul";
            person1.LastName = "Hoq";
            person1.PersonAddress = personAddress;



            string fullName = person1.FullName;
            //string reverseName = person1.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(person1.PersonAddress.GetFullAddress());

            Console.ReadKey();

        }
    }
}
