using System;

namespace Problem09 // Reverse an Array of Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            getArrayValues(array, length);
            reverseArray(array);


        }
        static void getArrayValues(int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static void reverseArray (int[] array)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
