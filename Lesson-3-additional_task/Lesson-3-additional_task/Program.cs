using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_additional_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел через запятую");
            string m = Console.ReadLine();
            string[] mas = m.Split(',');
            int[] arr = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                arr[i] = Convert.ToInt32(mas[i]);
               
            }
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = (arr.Length - 1);
            if (n > 0)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < p; i++)
                    {
                        int tmp = arr[p - i];
                        arr[p - i] = arr[(p - i) - 1];
                        arr[(p - i) - 1] = tmp;
                    }
                }
            }
            else
            {
                n = Math.Abs(n);
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < p; i++)
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
