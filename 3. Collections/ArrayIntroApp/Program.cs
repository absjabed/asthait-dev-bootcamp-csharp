using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[5];

            myIntArray[0] = 236;
            myIntArray[1] = 50;
            myIntArray[2] = 35;
            myIntArray[3] = 200;
            myIntArray[4] = 1523;

            Console.WriteLine("Length: "+ myIntArray.Length);

            Array.Sort(myIntArray);

            //for (int i = 0; i < myIntArray.Length; i++)
            //{
            //    Console.WriteLine(myIntArray[i]);
            //}

            foreach (int i in myIntArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
