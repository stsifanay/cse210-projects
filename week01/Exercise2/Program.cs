using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Input student grade percentage
        Console.Write("Enter your Grade ");
        string gradeValue = Console.ReadLine();
        int grade = int.Parse(gradeValue);

        string letter = "" ;

        if ( grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Grade sign (Without A and F)
        string sign = " ";
        if (letter != "A" && letter != "F")
        {
            int remainder = grade % 10;
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
        
        //Display student grade and sign
        }
        Console.WriteLine($"Your grade is {letter}{sign}");

        //Final decision 
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, try better next time");
        }
    }
}