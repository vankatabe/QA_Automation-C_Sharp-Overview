using System;

namespace QA_Automation_C_Sharp_Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days =" +
                $" {hours} hours = {minutes} minutes");
        }
    }
}
