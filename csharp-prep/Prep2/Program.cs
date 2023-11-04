using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade as a number? ");
        string gradeNumberStr = Console.ReadLine();
        int gradeNumber = int.Parse(gradeNumberStr);

        if (gradeNumber >= 90)
        {
            Console.WriteLine("Your grade letter is A");
        }
        else if (gradeNumber >= 80 && gradeNumber <90)
        {
            Console.WriteLine("Your grade letter is B");
        }
        else if (gradeNumber >= 70 && gradeNumber <80)
        {
            Console.WriteLine("Your grade letter is C");
        }
        else if (gradeNumber >= 60 && gradeNumber <70)
        {
            Console.WriteLine("Your grade letter is D");
        }
        else
        {
            Console.WriteLine("Your grade letter is F");
        }

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed, congratz.");
        }
        else
        {
            Console.WriteLine("You failed, better work harder.");
        }
    }
}