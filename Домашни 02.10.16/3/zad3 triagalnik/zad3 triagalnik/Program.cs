using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_triagalnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за намиране на лице на триъгълник по страна и височина");
            Console.WriteLine("Въведете страна а в см.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете височината Ha на триъгълника в см.");
            int Ha= int.Parse(Console.ReadLine());
            string lice = "Лицето на триъгълника е равно на ";
            string cmsq = " кв. см.";
            int res = (a * Ha / 2);
            Console.WriteLine(lice + res + cmsq);
        }
    }
}
