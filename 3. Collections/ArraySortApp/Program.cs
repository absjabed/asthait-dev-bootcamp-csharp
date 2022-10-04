using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] userArray = new int[5];
            // int[] sortedUserArray = new int[5];


            Console.WriteLine("Enter 5 numbers: ");
            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < userArray.Length; i++)
            {
                for (int j = 0; j < userArray.Length - 1; j++)
                {
                    if (userArray[j] > userArray[j + 1])
                    {
                        int temp;
                        temp = userArray[j + 1];
                        userArray[j + 1] = userArray[j];
                        userArray[j] = temp;
                    }
                }
            }

                foreach (int i2 in userArray)
                {
                    Console.WriteLine(i2);
                }

                Console.WriteLine("Maximum number in array:" + userArray[userArray.Length-1]);

                Console.ReadKey();
            }

        }
    }
