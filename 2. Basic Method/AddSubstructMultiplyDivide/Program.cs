using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubstructMultiplyDivideApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;

            Console.WriteLine("Enter First number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second number: ");

            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Addition of two numbers: "+Add(firstNumber,secondNumber));

            Console.WriteLine("Substruction of two numbers: " + Substruct(firstNumber, secondNumber));

            Console.WriteLine("Multiplication of two numbers: " + Multiply(firstNumber, secondNumber));

            Console.WriteLine("Divition of two numbers: " + Divide(firstNumber, secondNumber));

            Console.ReadKey();


        }

        static double Add(double firstnumber, double secondNumber)
        {
            return firstnumber + secondNumber;
        }

        static double Substruct(double firstnumber, double secondNumber)
        {
            return firstnumber - secondNumber;
        } 
        static double Multiply(double firstnumber, double secondNumber)
        {
            return firstnumber * secondNumber;
        }

        static double Divide(double firstnumber, double secondNumber)
        {
            return firstnumber / secondNumber;
        } 
    }
}
