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
            Write c# program to calculate Student grades
            --------------------------------------------------------------------------------------------
            Author   : Hossam El Hawy
            Subject  : C# Conditions
            Date     : 14/9/2024
            -------------------------------------------------------------------------------------------- 
             */

            int grade;
            Console.WriteLine("Please Enter your Grade");
            grade = int.Parse(Console.ReadLine());
            if (grade > 100)
            {
                Console.WriteLine("The Full Mark is 100");
                return;
            }
            if (grade >= 85)
                Console.WriteLine("Congratulations, your appreciation is excellent");
            else if (grade < 85 && grade >= 75)
                Console.WriteLine("Congratulations, your appreciation is very good");
            else if (grade < 75 && grade >= 65)
                Console.WriteLine("Congratulations, your appreciation is good");
            else if (grade < 65 && grade >= 50)
                Console.WriteLine("Congratulations, your appreciation is acceptable");
            else
                Console.WriteLine("Congratulations, your appreciation is acceptable");
        } 
    }
}
