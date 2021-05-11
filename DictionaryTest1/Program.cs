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

            Console.WriteLine("Example2");
            Example2();
            Console.WriteLine();

            Console.WriteLine("Example3");
            Example3();
            Console.WriteLine();

            Console.WriteLine("Example4");
            Example4();
            Console.WriteLine();

            Console.WriteLine("Example5");
            Example5();
            Console.WriteLine();

            Console.WriteLine("Example6");
            Example6();
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
            var dict2 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };

            dict2.Add("key3", "value3");
            dict2["key4"] = "value4";

            Console.WriteLine($"The count of key - value pairs: {dict2.Count}");

            foreach (var pair in dict2)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }

        private static void Example3()
        {
            var dict3 = new Dictionary<string, string>();

            dict3["key1"] = "value1";

            if (dict3.ContainsKey("key1"))
            {
                Console.WriteLine($"key1 = {dict3["key1"]}");
            }

            if (dict3.ContainsKey("key2"))
            {
                Console.WriteLine($"key2 = {dict3["key2"]}");
            }

            string result;

            if (dict3.TryGetValue("key1", out result))
            {
                Console.WriteLine($"key1 = {dict3["key1"]}");
            }
        }

        private static void Example4()
        {
            var dict4 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };

            try
            {
                Console.WriteLine($"key3 = {dict4["key3"]}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Example5()
        {
            var dict5 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key11", "value11" },
                { "key22", "value22" }
            };

            var list =
                dict5
                .Where(pair => pair.Key.EndsWith("1"))
                .Select(pair => pair.Value)
                .OrderBy(value => value)
                .ToList();

            list.ForEach(x => Console.WriteLine(x));
        }

        private static void Example6()
        {
            var dict6 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key11", "value11" },
                { "key22", "value22" },
                { "key44", "value1" },
                { "key55", "value2" }
            };

            Console.WriteLine("Keys in the dictionary:");

            foreach (var key in dict6.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();

            Console.WriteLine("Values in the dictionary:");

            foreach (var value in dict6.Values.Distinct())
            {
                Console.WriteLine(value);
            }
        }
    }
}
