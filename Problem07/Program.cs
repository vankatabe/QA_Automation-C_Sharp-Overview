using System;

namespace Problem07
{
    class Program //Draw a Filled Square
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFirstOrLastRow(n);
            for (int i = 0 + 1; i < n - 1; i++)
            {
                PrintMiddleRow(n);
            }
            PrintFirstOrLastRow(n);
        }
        static void PrintFirstOrLastRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.WriteLine('-' + MiddlePartOfMiddleRow(n) + '-');
        }
        static string MiddlePartOfMiddleRow(int n)
        {
            string middlePart = "";
            for (int i = 0; i < n - 1; i++)
            {
                middlePart = middlePart + "\\/";
            }
            return middlePart;
        }
    }
}
