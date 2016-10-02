using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8_nomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за извеждане на 14-тия символ от текста на екрана //програмата работи с стрингове с минимум 15 символа!");
            Console.WriteLine("Въведете текст");
             string str = Console.ReadLine();
                    char res = (str[14]);
                    string final = ("Четиринадесетия символ от въведения текст е ");
                    Console.WriteLine(final + res);
        }
    }
}
