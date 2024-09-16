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
            Write c# program Swap minimum number with maximum number in array.
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 17/9/2024
            -------------------------------------------------------------------------------------------- 
             */
            int n = 8, max = 0, min = 0, x = 0, y = 0, z = 0;
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // initializing------
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            //finding maximum--------
            for (int k = 1; k < n; k++)
            {
                if (arr[k] > arr[max])
                    max = k;

            }


            // finding mimimum--------
            for (int h = 0; h < n; h++)
            {
                if (arr[h] < arr[min])
                    min = h;

            }
            //swaping-----
            x = arr[min];

            arr[min] = arr[max];
            arr[max] = x;

            for (int a = 0; a < n; a++)
            {

                Console.Write(arr[a] + " ");
            }


        }
    }
}


