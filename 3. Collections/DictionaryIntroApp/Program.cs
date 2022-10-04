using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            
            myDictionary.Add(101, "CSE101");
            myDictionary.Add(102, "CSE102");
            myDictionary.Add(103,"CSE103");
            myDictionary.Add(104, "CSE104");
            myDictionary.Add(105, "CSE105");
            myDictionary[105] = "CSE106";

            Console.WriteLine(myDictionary.ContainsValue("CSE105"));
            Console.WriteLine(myDictionary.Remove(105));
            Console.WriteLine(myDictionary.ContainsKey(105));
            foreach (KeyValuePair<int, string> keyValuePair in myDictionary)
            {
                Console.WriteLine(keyValuePair.Key +":"+keyValuePair.Value);
            }

            Console.ReadKey();

        }
    }
}
