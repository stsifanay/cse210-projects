using System;

class Program
{
    static void Main(string[] args)
    {
        //Asking userd their name
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("This is C#.");

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.Write($"Your name is {firstname}, {firstname} {lastname}");

    }
}