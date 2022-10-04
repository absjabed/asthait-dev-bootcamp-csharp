using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number%2 == 0)
            {
                
                Console.WriteLine("If");
            }
            else if (number == 10)
            {
                //this portion will never be excuted 
                Console.WriteLine("Else If");
            }
            else
            {

                Console.WriteLine("Else");
            }

            Console.Read();
        }
    }
}
