using System;

namespace AdIns
{
    class Soal5
    {
        public static void Run()
        {
            Console.Write("Input 1: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2: ");
            int input2 = int.Parse(Console.ReadLine());
            string output = FormatNumber(input1, input2);
            Console.WriteLine("Output: " + output);
        }

        static string FormatNumber(int number, int totalDigits)
        {
            return number.ToString().PadLeft(totalDigits, '0');
        }
    }
}
