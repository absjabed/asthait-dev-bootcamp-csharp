using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("ArrayList");
            myQueue.Enqueue("List");
            myQueue.Enqueue("Queue");
            myQueue.Enqueue("Stack");

            string[] myArray = myQueue.ToArray();

            Console.WriteLine(myQueue.Contains("Array"));

            Console.WriteLine("Dequeue: "+ myQueue.Dequeue());
            Console.WriteLine("Peek: "+ myQueue.Peek());

            foreach (string s in myArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
