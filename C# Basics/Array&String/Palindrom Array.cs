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
            Write c# program to determine if the array is palindrome or not
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 17/9/2024
            -------------------------------------------------------------------------------------------- 
             */
            int n = 4;
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            bool p = true;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); ;
            }

            for (int x = 0; x <= n / 2; x++)
            {
                if (arr[x] != arr[n - x - 1])
                {
                    p = false;
                    break;
                }
            }

            if (p)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}


