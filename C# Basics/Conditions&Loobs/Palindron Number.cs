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
            Write c# program to get the palendrom number 
                [A palindrome number is a number that reads the same forward or backward.]
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 16/9/2024
            -------------------------------------------------------------------------------------------- 
             */

            int n, num, digit, x = 0, t = 0, count = 1;
            num = int.Parse(Console.ReadLine());
            n = num;
            if (num > 10)
            {
                Console.Write("The Palindrom Number In Your Input Is ");

            }
            for (int i = 10; i <= 10 * num; i *= 10)
            {
                if (num < 10)
                {
                    Console.WriteLine($"The Palindrom Number In Your Input Is {num}");
                    break;
                }

                t = (num % i) / (i / 10);
                if (count == 1 && t != 0)
                {
                    Console.Write(t);
                    count++;
                }

                else if (count != 1)
                    Console.Write(t);
            }

            do
            {
                digit = num % 10;
                x = (x * 10) + digit;
                num /= 10;
            } while (num != 0);


            if (n == x)
                Console.WriteLine("\nYes,Your Number Is Palindrom ");
            else
                Console.WriteLine("\nNo, Your Number Is Not Palindrom ");
        }
    }
}


