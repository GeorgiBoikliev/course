using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за сравняване на изрази с думата Hello");
            Console.WriteLine("Въведете израз");
            string text1 = Console.ReadLine();
            string text2 = "Hello";
            Console.WriteLine(text1 == text2);
        }


    }
}
