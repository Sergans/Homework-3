using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово, чтобы вывести его наоборот ");
            string a = Console.ReadLine();
            string c = "";
            char[] b = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            //char[]b = a.ToArray(); Упрощенный вариант разбиения строки на символы

            for (int i = a.Length - 1; i >= 0; i--)
            {

                c += b[i];

            }
            Console.WriteLine(c);
        }
    }
}
