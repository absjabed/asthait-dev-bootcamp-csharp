using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> func1 = x => x + 1;                          //Last Type ta holo Return Type baki sob Parameter Type
            Console.WriteLine(func1.Invoke(9));

            Func<int, int, int> func2 = (x, y) => x + y;                //As Like Add Method()
            Console.WriteLine(func2.Invoke(9, 9));

            List<string> names = new List<string>() { "Rimi", "Hasan", "Arafeen", "Hossain" };

            string found = names.Find(name => name.StartsWith("H"));
            var foundNames = names.FindAll(x => x.Contains("a"));

            Console.WriteLine(found);
            Console.WriteLine("\n");
            foreach (var name in foundNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");

            List<double> values = new List<double>() { 4, 5, 77, 15, 3, 25 };
            double aNumber = values.Find(number => (number >= 5));
            Console.WriteLine(aNumber);

            List<Book> books = new List<Book> { 
                new Book { Author="Mcconnell",Name="Code Complete", Published=new DateTime(1993,05,14) },
                new Book { Author="Sussman",Name="SICP (2nd)", Published=new DateTime(1996,06,01) },
                new Book { Author="Hunt",Name="Pragmatic Programmer", Published=new DateTime(1999,10,30) },
            };

            var selectedBooks = books.FindAll(book => book.Published > (new DateTime(1995, 12, 31)));

            var selectedBooks2 = books.FindAll(b => b.Author.Contains("u"));

            Console.WriteLine("\n");
            foreach (var book in selectedBooks)
            {
                Console.WriteLine(book.Published.Year);
            }

            Console.WriteLine("\n");
            foreach (var book in selectedBooks2)
            {
                Console.WriteLine(book.Author);
            }


            Console.ReadKey();
        }
    }
}
