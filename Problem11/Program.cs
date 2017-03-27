using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11 // Sum Adjacent Equal Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] == list[i])
                {
                    list[i - 1] += list[i];
                    list.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
