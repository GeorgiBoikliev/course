using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readline_your_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за събиране на две числа");
            Console.WriteLine("Въведете първото число");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете второ число");
            int B = int.Parse(Console.ReadLine());
            int C = A + B;
            string result = "Сборът на двете числа е ";
            Console.WriteLine(result + C);
        }
    }
}
