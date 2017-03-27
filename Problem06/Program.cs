using System;

namespace Problem06
{
    class Program //Printing Triangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Print rows until middle; middle row incluced
            for (int rowNumber = 1; rowNumber <= n; rowNumber++)
            {
                PrintColumnsInARow(rowNumber);
            }
            //Print rows after middle
            for (int rowNumber = n - 1; rowNumber >= 1; rowNumber--)
            {
                PrintColumnsInARow(rowNumber);
            }
        }
        static void PrintColumnsInARow(int rowNumber)
        {
            for (int column = 1; column <= rowNumber; column++)
            {
                Console.Write(column + " ");
            }
            Console.WriteLine();
        }
    }
}
