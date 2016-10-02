using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5_konkatenir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за получаване на конкатениран стринг");
            string a = "много(мало)";
            char _ = '_';
            string b = "умен";
            string result = a + _ + b;
            Console.WriteLine(result);
        }
    }
}
