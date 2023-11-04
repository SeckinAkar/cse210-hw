using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        // Console.WriteLine(number);
        
        bool userGuess = false;

        while (userGuess == false)
        {
            Console.Write("What is the magic number? ");
            string stringGuess = Console.ReadLine();
            int guess = int.Parse(stringGuess);

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct!");
                userGuess = true;
            }
        }

    }
}