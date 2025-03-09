using System;

class Program
{
    static void Main(string[] args)
    {
     
     //Creating the list syntax
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {

        //Asking user to enter a number with an option to quit when 0
        Console.Write("Please enter a number, 0 to quit ");
        string userResponse = Console.ReadLine();
        //converting the answer from string to integer 
        userNumber = int.Parse(userResponse);

        if (userNumber != 0)
            {
            numbers.Add(userNumber);
            }
            
        //Compute the sum of words
        int wordSum = 0;
        foreach (int number in numbers)
            {
            wordSum += number;
            }

        Console.WriteLine($"The sum is: {wordSum}");

        //Compute the average 
        float average = ((float)wordSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Compute the max
        int max = numbers[0];
        foreach (int number in numbers)
        if (number > max)
            {
            max = number;
            }
        Console.WriteLine($"The max is: {max}");
        }
    }
}