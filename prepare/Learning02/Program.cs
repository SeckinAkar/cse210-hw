using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // Job 1
        Job job1 = new Job();
        job1._jobTitle = "English Teacher";
        job1._company = "MEB";
        job1._startYear = 2021;
        job1._endYear = 2023;

        // Job 2
        Job job2 = new Job();
        job2._jobTitle = "Administrator";
        job2._company = "MEB";
        job2._startYear = 2023;
        job2._endYear = 2023;
        
        // Reusme
        Resume myResume = new Resume();
        myResume._name = "Seçkin Akar";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}