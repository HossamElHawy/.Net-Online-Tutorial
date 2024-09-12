namespace CsharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
--------------------------------------------------------------------------------------------
The question is :
Write c#  Simple Calculator program 
--------------------------------------------------------------------------------------------
Author   : Hossam El Hawy
Subject  : C# Conditions
Date     : 14/9/2024
-------------------------------------------------------------------------------------------- 
*/
            int num1,num2;
            char symbole;
            Console.Write("Please Enter Your First Number : ");
            num1=int.Parse(Console.ReadLine());

            Console.Write("Please Enter Symbole [ +,-,*,/ ] : ");
            symbole = char.Parse(Console.ReadLine());

            Console.Write("Please Enter Your Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            switch (symbole)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default : Console.WriteLine("Please Enter Correct Symbole [+,-,*,/]");
                    break;

            }
        }
    }
}
