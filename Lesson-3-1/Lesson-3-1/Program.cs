using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int s = 0; s < a.GetLength(0); s++)
            {
                for (int f = 0; f < a.GetLength(1); f++)

                {

                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        for (int i = 0; i < a.GetLength(1); i++)
                        {
                            if (a[j, i] == a[s, f])
                            {
                                Console.Write(a[j, i]);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }

                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
