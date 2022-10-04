using System;
using System.Collections.Generic;

namespace AnonymousTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCustomer = new {Name = "Jamil", Id = "152365", Address = "Chittagong"};
            var aStudent = new {RegNo = "125498", Name = "Annan", Email = "qwerty@Chittagong.com"};

            string s = aCustomer.Name;

            var aTrainee = new {SEID = "123655", Name = "Kamrul"};

            var names = new[] {"Kabil", "Gopal", "WWW"};
            var number = new[] {21.5, 25, 30.2};

            var aList = new[]
            {
                new {RegNo = "125498", Name = "Annan", Email = "Annan@Chittagong.com"},
                new {RegNo = "225566", Name = "Kazi", Email = "Kazi@Chittagong.com"},
                new {RegNo = "445577", Name = "Kamrul", Email = "kamrul@Chittagong.com"},
            };

            ShowAll(aList);

            doNothing(1);
            doNothing(1.5);
            doNothing("qwerty");

            Console.ReadKey();
        }

        private static void ShowAll(IEnumerable<dynamic> aList)
        {
            foreach (var varName in aList)
            {
                Console.WriteLine("\n" + varName.Name + " => " + varName.RegNo + " => " + varName.Email);
            }
        }

        static void doNothing(dynamic a)
        {
            
        }

    }
}
