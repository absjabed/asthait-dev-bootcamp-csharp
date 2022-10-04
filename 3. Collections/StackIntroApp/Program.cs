using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();

            myStack.Push("ArrayList");
            myStack.Push("List");
            myStack.Push("Queue");
            myStack.Push("Stack");

            string[] myArray = myStack.ToArray();

            Console.WriteLine(myStack.Contains("Array"));

            Console.WriteLine("Pop: " + myStack.Pop());
            Console.WriteLine("Peek: " + myStack.Peek());

            foreach (string s in myArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }
    }
}
