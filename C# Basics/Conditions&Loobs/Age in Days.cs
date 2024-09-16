using System;

namespace CsharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            --------------------------------------------------------------------------------------------
            The question is :
            Write c# program to convert age from days to years
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 14/9/2024
            -------------------------------------------------------------------------------------------- 
             */

            int num, year, month, remain;
            Console.WriteLine("Please Enter your age in days : ");
            num = int.Parse(Console.ReadLine());
            year = num / 365;
            remain = num % 365;
            month = remain / 30;
            remain = remain - 30 * month;
            Console.WriteLine($"{year} years");
            Console.WriteLine($"{month} months");
            Console.WriteLine($"{remain} days");
        }
    }
}
