using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArrayAverageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers;

            Console.WriteLine("How many numbers? ");
            numbers = Convert.ToInt32(Console.ReadLine());

            double[] userArray = new double[numbers];
            double total = 0, average;

            Console.WriteLine("Enter " + numbers + " numbers: ");
            for (int i = 0; i < numbers; i++)
            {
                userArray[i] = Convert.ToDouble(Console.ReadLine());
                total += userArray[i];
            }

            average = total/userArray.Length;
            Console.WriteLine("Average of numbers: "+ average);
            Console.ReadKey();

        }
    }
}
