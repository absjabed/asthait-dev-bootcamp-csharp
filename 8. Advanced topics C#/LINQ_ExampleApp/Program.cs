using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book{Title="Prejudice",Price=2300},
                new Book{Title="Justice",Price=1500},
                new Book{Title="SQL",Price=4300},
                new Book{Title="Java",Price=300},
            };

            //var selectedBooks = books.Where(b => b.Price > 2000);
            var selectedBooks = from b in books
                where b.Price > 1000
                select b;

            var sBooks = books.Where(b => b.Price > 2000);

            List<int> sbooks = books.Where(X => X.Price > 1000).Select(book => book.Price).ToList();
            IEnumerable<string> bookList = books.Where((book => book.Title.Contains("P"))).Select(book => book.Title);

            foreach (int i in sbooks)
            {
                 Console.WriteLine(i);
            }
            foreach (Book book in selectedBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadKey();
        }
    }
}
