using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Ostatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //решение 1
            Console.WriteLine("Програма за показване на остатък от деление на целочислени числа //метод 1");
            Console.WriteLine("въведи цяло число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("въведи второ цяло число");
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            int ostatak = a - (b * c);
            Console.WriteLine(ostatak);

            //решение 2
            //Console.WriteLine("Програма за показване на остатък от деление на целочислени числа //метод 2");
            //Console.WriteLine("въведи цяло число");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("въведи второ цяло число");
            //int b = int.Parse(Console.ReadLine());
            //int result = a % b;
            //Console.WriteLine(result);

            //решение 3(евентуално)
            //Console.WriteLine("Програма за показване на остатък от деление на целочислени числа //метод 3");
            //Console.WriteLine("въведи цяло число");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("въведи второ цяло число");
            //float b = float.Parse(Console.ReadLine());
            //float c = a / b;
            //int tsyalo = Convert.ToInt32(c);
            //float razlika = c - tsyalo;
            //Console.WriteLine(razlika);
        }
    }
}
