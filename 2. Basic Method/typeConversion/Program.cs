using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 97;
            double d = 15.5;
            long l = 500000;

            l = i;
            i = Convert.ToInt32(l);

            char c = Convert.ToChar(i);

            bool b = false;

            i = Convert.ToInt32(c);

            Console.WriteLine(c);

            Console.ReadKey();

        }
    }
}
