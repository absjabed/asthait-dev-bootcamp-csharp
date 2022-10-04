using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingResultWithMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int obtainedNumber;
                Console.WriteLine("Enter a number between 0 ~ 100 : ");
                obtainedNumber = Convert.ToInt32(Console.ReadLine());
                GradingResult(obtainedNumber);
            }
        }
        static void GradingResult(int number)
        {
            if (number >= 0 && number <= 39)
                {
                    Console.WriteLine("F");
                }
                else if (number >= 40 && number <= 59)
                {
                    Console.WriteLine("A-");
                }
                else if (number >= 60 && number <= 79)
                {
                    Console.WriteLine("A");
                }
                else if (number >= 80 && number <= 100)
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
