using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6_Realno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за делене на реално на цяло число");
            Console.WriteLine("въведи реално число");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("въведи цяло число");
            float b = float.Parse(Console.ReadLine());
            float c = a / b;
            Console.WriteLine(c);
        }
    }
}
