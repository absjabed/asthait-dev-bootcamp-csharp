using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashtable = new Hashtable();
            
            myHashtable.Add("Hello", "World");
            myHashtable.Add('A', 101);
            myHashtable.Add(1.6, 16);
            myHashtable.Add(20, 2000);

            myHashtable[202] = 'Q';
            myHashtable[20] = "Changed Value";

            Console.WriteLine(myHashtable.Contains(201));
            Console.WriteLine(myHashtable.ContainsKey(20));
            Console.WriteLine(myHashtable.ContainsValue("Changed Value"));

            Console.WriteLine(myHashtable[20]);

            foreach (DictionaryEntry entry in myHashtable)
            {
                Console.WriteLine(entry.Key +":"+ entry.Value);
            }


            Console.ReadKey();
        }
    }
}
