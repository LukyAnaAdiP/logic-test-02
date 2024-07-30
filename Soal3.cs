using System;
using System.Collections.Generic;

namespace AdIns
{
    class Soal3
    {
        public static void Run()
        {
            Console.Write("Input: ");
            int input = int.Parse(Console.ReadLine());
            List<int> fibonacciSequence = GenerateFibonacci(input);
            Console.WriteLine("Output: " + string.Join(" ", fibonacciSequence));
        }

        static List<int> GenerateFibonacci(int n)
        {
            List<int> fib = new List<int> { 1, 1 };
            while (true)
            {
                int nextFib = fib[^1] + fib[^2];
                if (nextFib > n)
                    break;
                fib.Add(nextFib);
            }
            return fib;
        }
    }
}
