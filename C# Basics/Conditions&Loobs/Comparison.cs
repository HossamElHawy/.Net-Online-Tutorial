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
            Date     : 14/9/2024
            -------------------------------------------------------------------------------------------- 
             */

            int num1,num2;
            char sign;
            Console.WriteLine("Please Enter Your First Number : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Your Sign : ");
            sign = char.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Your Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            switch (sign)
            {
                case '<':
                    if (num1 < num2)
                        Console.WriteLine("Right");
                    else
                        Console.WriteLine("Wrong");
                    break;

                case '>':
                    if (num1 > num2)
                        Console.WriteLine("Right");
                    else
                        Console.WriteLine("Wrong");
                    break;

                case '=':
                    if (num1 == num2)
                        Console.WriteLine("Right");
                    else
                        Console.WriteLine("Wrong");
                    break;

                    default:
                    Console.WriteLine("Please Check Your sign ");
                    break;
            }
        } 
    }
}
