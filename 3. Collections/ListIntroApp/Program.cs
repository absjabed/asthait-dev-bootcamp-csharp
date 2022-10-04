using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> mylList = new List<string>();

            mylList.Add("123");
            mylList.Add("Hello");
            mylList.Add("World");
            mylList.Add("BITM");
            mylList.Add("DotNet");
            mylList.Add("Batch 38");

            mylList.Remove("BITM");


            Console.WriteLine("Count: {0}", mylList.Count);

            mylList.Sort();
            mylList.Reverse();

            foreach (string s in mylList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
