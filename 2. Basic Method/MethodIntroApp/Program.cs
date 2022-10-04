using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            double result = Add(18.6, 23.7);
            Console.WriteLine(result);
            Console.WriteLine(Add(96, 12.4));
            Console.WriteLine();
            Console.ReadKey();


        }

        static void Print()
        {
            Console.WriteLine("Hello from Print method");
        }

        static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
    }
}
