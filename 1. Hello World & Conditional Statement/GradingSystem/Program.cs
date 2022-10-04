using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int number;
                Console.WriteLine("Enter a number between 0 ~ 100 : ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number >= 0 && number <= 39)
                {
                    Console.WriteLine("F");

                }
                else if (number >= 40 && number <= 49)
                {
                    Console.WriteLine("C");

                }
                else if (number >= 50 && number <= 59)
                {
                    Console.WriteLine("B");

                }
                else if (number >= 60 && number <= 69)
                {
                    Console.WriteLine("B+");

                }
                else if (number >= 70 && number <= 79)
                {
                    Console.WriteLine("A-");

                }
                else if (number >= 80 && number <= 89)
                {
                    Console.WriteLine("A");

                }
                else if (number >= 90 && number <= 100)
                {
                    Console.WriteLine("A+");

                }
                else 
                {
                    Console.WriteLine("Out of Range!");

                }
            }

        }
    }
}
