using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add(12);
            myArrayList.Add(2.6);
            myArrayList.Add(true);
            myArrayList.Add('R');
            myArrayList.Add(12);

            Console.WriteLine("Count: "+ myArrayList.Count);

            foreach (var data in myArrayList)
            {
                Console.WriteLine(data);
            }

            //Console.WriteLine(myArrayList.Contains(2.7));

            //myArrayList.Remove("Hello");
            //Console.WriteLine("Count: " + myArrayList.Count);
        
            //myArrayList.RemoveAt(0);
            //Console.WriteLine("Count: " + myArrayList.Count);


            Console.WriteLine("REVERSE:");
            myArrayList.Reverse();
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }


            Console.WriteLine("REMOVE renge:");
            myArrayList.RemoveRange(0,1);
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.ReadKey();

        }
    }
}
