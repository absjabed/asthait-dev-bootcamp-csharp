using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndCollectionInitializerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee trainee1 = new Trainee();
            trainee1.SEID = "152478";
            trainee1.NAME = "Saddam";

            var trainee2 = new Trainee() {SEID = "154879"};
            trainee2.NAME = "Miraz";

            var ourList = new List<string> {"Saddam", "Jewel", "Akib", "Arnab"};
            ourList.Add("ABS JBD");

            foreach (var name in ourList)
            {
                Console.WriteLine(name);
            }

            var trainees = new List<Trainee>
            {
                trainee1, trainee2,
                new Trainee{SEID = "124578", NAME = "Rubel"}
            };

            foreach (var trainee in trainees)
            {
                Console.WriteLine(trainee.SEID+"=>"+trainee.NAME);
            }

            Console.ReadKey();
        }
    }
}
