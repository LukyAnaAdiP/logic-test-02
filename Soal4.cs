using System;

namespace AdIns
{
    class Soal4
    {
        public static void Run()
        {
            Console.Write("Input: ");
            int input = int.Parse(Console.ReadLine());
            PrintStarPattern(input);
        }

        static void PrintStarPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
