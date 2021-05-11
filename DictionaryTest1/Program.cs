using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example1");
            Example1();
            Console.WriteLine();

            Console.WriteLine("Example1");
            Example2();
            Console.WriteLine();
        }
        
        private static void Example1()
        {
            var dict1 = new Dictionary<string, string>();

            dict1["key1"] = "value1a";
            dict1["key2"] = "value2a";

            foreach (KeyValuePair<string, string> pair in dict1)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }

            Console.WriteLine();

            dict1["key1"] = "value1b";
            dict1["key2"] = "value2b";

            foreach (var pair in dict1)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }

        private static void Example2()
        {
            
        }
    }
}
