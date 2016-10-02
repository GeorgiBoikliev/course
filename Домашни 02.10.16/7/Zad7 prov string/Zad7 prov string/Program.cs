using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7_prov_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за проверка за съдържание на един стринг в друг стринг");
            Console.WriteLine("Въведете текст");
            string A = Console.ReadLine();
            Console.WriteLine("Въведете текст 2");
            string B = Console.ReadLine();
            bool amadali = A.Contains(B);
            Console.WriteLine(amadali);

            //програмата проверява дали стринг Б  се съдържа в стринг А
        }
    }
}
