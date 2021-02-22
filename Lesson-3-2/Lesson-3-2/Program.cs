using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[,] spravker = { { "Sergey", "121212" }, { "Ivan", "232323" }, { "Vovan", "323232" }, { "Vasya", "454545" }, { "Katya", "kat@mail.ru" } };
            //Вывести справочник при нажатии
            Console.WriteLine("Нажмите клавишу для выведения списка контактов");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < spravker.GetLength(0); i++)
            {
                Console.WriteLine($"{spravker[i, 0]}:{spravker[i, 1]}");
            }
        }
    }
}
