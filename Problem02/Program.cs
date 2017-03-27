using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Radius = ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine($"{area:f12}");
        }
    }
}
