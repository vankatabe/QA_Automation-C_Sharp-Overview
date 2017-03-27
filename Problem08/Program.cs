using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    public class Problem08
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            // Another way to fill-in the Array
            string daysOfWeekValues = "Monday Tuesday Wednesday Thursday Friday Saturday Sunday";
            string[] daysOfWeek2 = daysOfWeekValues.Split(' ');
            // There are a few more rows if we need to parse to int - see the pptx

            int dayNumber = int.Parse(Console.ReadLine());
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(daysOfWeek2[dayNumber - 1]);

            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
