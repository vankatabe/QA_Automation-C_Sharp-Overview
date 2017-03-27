using System;

namespace Problem05 //Sign Of Integer Number
{
    class Problem05
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSign(n);
        }
        static void PrintSign(int number)
        {
            string uniformPartOfString = $"The number {number} is ";
            string distinctiveString = "";

            if (number > 0)
            {
                distinctiveString = PositiveNumberString(number);
            }
            else if (number < 0)
            {
                distinctiveString = NegativeNumberString(number);
            }
            else if (number == 0)
            {
                distinctiveString = ZeroNumberString(number);
            }
            Console.WriteLine(uniformPartOfString + $"{distinctiveString}.");
        }
        static string PositiveNumberString(int positiveNumber)
        {
            string endPartOfString = "positive";
            return endPartOfString;
        }
        static string NegativeNumberString(int negativeNumber)
        {
            string endPartOfString = "negative";
            return endPartOfString;
        }
        static string ZeroNumberString(int zeroNumber)
        {
            string endPartOfString = "zero";
            return endPartOfString;
        }
    }
}