using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        List<int> numbers = new List<int>();

        int userGuess = -1;
        int sum = 0;

        while (userGuess != 0)
        {
            Console.Write("Enter a number: ");
            
            string userResponse = Console.ReadLine();
            userGuess = int.Parse(userResponse);
            
            if (userGuess != 0)
            {
                numbers.Add(userGuess);
            }
        }
        
        // Finding sum:
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Finding average:
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Finding the minimum number:
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest number is: {min}");
    }
}