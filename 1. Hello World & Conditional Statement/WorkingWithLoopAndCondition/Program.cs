using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithLoopAndCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;

            for (int i = 1; i <= 100; i++)
            {
                
               
               
               if(i%2 == 1)
                {
                    Console.Write(i+" ");
                } 
                else if (i%2 == 0)
                {

                    if (k == 10)
                    {

                        Console.Write(" dotnet");
                        Console.WriteLine();
                        k = 0;
                    }
                    else
                    {
                        Console.Write(" dot");
                    }
                }


                k++;
                
            }

            Console.Read();

        }
    }
}
