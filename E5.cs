// 213034 Muneeb Shahid

using System;

namespace program
{
    class TestArrayCalss
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[5] {1, 3, 5, 7, 9 };

            arr[1] = new int[4]{ 2, 4, 6, 8};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element ({0}) : " , i);

                for (int j = 0; j <arr.Length; j++)
                {
                    Console.Write($"arr({0})arr({1})", arr[i][j] == (arr[i].Length - 1) ? "" : " " );

                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit. ");
            Console.ReadKey();

        }
    }
}