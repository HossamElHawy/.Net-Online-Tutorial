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
            Write c# program to determine if the number is prime or not 
              [A prime number is a number that is greater than 1 and has only two factors which are 1 and itself.]
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 16/9/2024
            -------------------------------------------------------------------------------------------- 
             */

            int n;
            string s="";
             n= int.Parse(Console.ReadLine());
            if (n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        if (i == n)
                            s = "YES";

                        else
                        {
                            s = "NO";
                            break;
                        }
                    }
                    else
                        s = "NO";

                }

            }
            else
            {
                s = "NO";
            }
             Console.WriteLine($"The Check Of Yoer Number Prim or Not is :{s}");

         


        }
    }
} 
    

