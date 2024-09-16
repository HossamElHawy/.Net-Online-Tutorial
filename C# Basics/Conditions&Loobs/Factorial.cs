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
            Write c# program to compare between 2 numbers
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 16/9/2024
            -------------------------------------------------------------------------------------------- 
             */

            int n, num, fact = 1;
            Console.WriteLine("Please Enter Number Of Tests : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Please Enter Your Number : ");
                num = int.Parse(Console.ReadLine());
                for (int f = num; f > 0; f--)
                {
                    fact *= f;

                }
                Console.WriteLine($" The Factorial Of {num} Is : {fact}\n");
                fact = 1;

            }
        }
    }
}
