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
            Write c# program to Search a number In Matrix
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 17/9/2024
            -------------------------------------------------------------------------------------------- 
             */
            int n = 2, m = 2, x = 0;
            n=int.Parse(Console.ReadLine());
            m=int.Parse(Console.ReadLine());
            int[,] arr=new int[n,m] ;
            bool f = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   arr[i,j]= int.Parse(Console.ReadLine());
                }
            }
             x= int.Parse(Console.ReadLine());

            for (int i2 = 0; i2 < n; i2++)
            {
                for (int j2 = 0; j2 < m; j2++)
                {
                    if (x == arr[i2,j2])
                        f = true;

                }
            }
            if (f == true)
               Console.WriteLine("the number exists");
            else
                Console.WriteLine("the number doesn't exist");
        }
    }
} 
    

