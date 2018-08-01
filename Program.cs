using System;
using System.Collections.Generic;

namespace Generics{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = {"a","b","c","d","ee","ff","gas"};
            string[] swapped = Generic<string>.swap(2,4,array1);
            Console.WriteLine(String.Join(" ",swapped));
            // Generic<string> gen = new Generic<string>();
            // gen.array = array1;
            // string[] removed = gen.removeValue("c");
            // Console.WriteLine(String.Join(" ",removed));
        }
    }
}
