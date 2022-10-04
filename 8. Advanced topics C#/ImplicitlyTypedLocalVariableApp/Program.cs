using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVariableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 234;
            var s = "BITM- PUC_4D";
            bool b;
            b = true;

            var ourList = new List<string>();
            ourList.Add("Hello");
            ourList.Add("BITM");
            ourList.Add("SEIP");
            ourList.Add("Batch 38");



            Trainee trainee1 = new Trainee();
            trainee1.SEID = "157540";
            trainee1.NAME = "Jamila Afa";

            var trainee2 = new Trainee();
            trainee2.SEID = "141523";
            trainee2.NAME = "Megan";

            var trainees = new List<Trainee>();
            trainees.Add(trainee1);
            trainees.Add(trainee2);

            Console.WriteLine(s+"-----"+i);

            Console.ReadKey();
        }
    }
}
