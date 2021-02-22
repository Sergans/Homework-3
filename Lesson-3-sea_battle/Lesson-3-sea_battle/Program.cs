using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_sea_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа без проверки выхода за границы массива
            Console.WriteLine("Заполните поле кораблями(3 корабля)");
            //Создаем массив,заполняем его симолом 'O' 
            char[,] sea = new char[10, 10];
            int ship = 1;
            for (int j = 0; j < sea.GetLength(0); j++)
            {
                for (int i = 0; i < sea.GetLength(1); i++)
                {
                    sea[j, i] = 'O';

                }

            }

            do
            {

                Console.WriteLine($"Введите начальную координату по вертикали корабля номер-{ship}");
                int position1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите начальную координату по горизонтали корабля номер-{ship} (Если ранг равен 5, то максимально 5)");
                int position2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите ранг корабля номер-{ship} (Число от 0 до 5)");
                int rang = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < rang; i++)

                {
                    sea[position1, position2 + i] = 'X';
                }
                ship++;
            } while (ship < 4);
            for (int j = 0; j < sea.GetLength(0); j++)
            {
                for (int i = 0; i < sea.GetLength(1); i++)
                {
                    Console.Write(sea[j, i]);

                }
                Console.WriteLine();
            }
            //Вариант ручной записи расположение кораблей
            /* sea[2, 1] = 'X';
             sea[2, 2] = 'X';
             sea[2, 3] = 'X';
             sea[2, 4] = 'X';*/
        }
    }
}
