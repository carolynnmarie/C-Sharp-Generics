using System;
using System.Collections.Generic;

namespace Generics{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> list = new List<int>();
            // list.Add(2);
            // list.Add(3);
            // list.Add(5);
            // Generic<int> id = new Generic<int>();
            // int x = Generic<int>.min(list);
            // Console.WriteLine(x.ToString());
            string[] array =  {"a","b","c","d"};
            string[] array2 = {"d","e","f","g"};
            Generic<string> gen = new Generic<string>(array);
            int y = gen.countDuplicatesInMerge(array2, "d");
            Console.WriteLine(y.ToString());
        }
    }
}
