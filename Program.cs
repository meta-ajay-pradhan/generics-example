using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CompareClass<string> obj = new CompareClass<string>();
            bool result = obj.Compare("hello", "hello");
            if (result)
                Console.WriteLine("equal");
            else
                Console.WriteLine("Not equal");

            List<int> Numbers = new List<int>();
            Numbers.Add(1);
            Numbers.Add(3);
            Numbers.Add(5);
            Numbers.Add(7);

            bool result2 = obj.EmptyOrNot(Numbers);
            if (result2)
                Console.WriteLine("not empty");
            else
                Console.WriteLine("empty");
        }
    }
}