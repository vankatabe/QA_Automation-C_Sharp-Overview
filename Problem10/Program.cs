using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10 // Remove Negatives and Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            makeTheNumbersList(nums);

            List<int> nonNegativeAndReversedNums = new List<int>();
            int listPosition = 0;
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] >= 0)
                {
                    nonNegativeAndReversedNums.Add(nums[i]);
                    Console.Write(nonNegativeAndReversedNums[listPosition] + " ");
                    listPosition++;
                }
            }
            if (nonNegativeAndReversedNums.Count == 0)
            {
                Console.WriteLine("empty");
            }
        }
    

    static void makeTheNumbersList(List<int> nums)
    {
        string values = Console.ReadLine();
        List<string> items = values.Split(' ').ToList();
        for (int i = 0; i < items.Count; i++)
        {
            nums.Add(int.Parse(items[i]));
        }
    }
}
}
