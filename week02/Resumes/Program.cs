using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Company";
        job1._startYear = "2020";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Web Company";
        job2._startYear = "2018";
        job2._endYear = "2020";

        // Console.WriteLine($"Job 1:{job1._company}");
        // Console.WriteLine($"Job 2:{job2._company}");

        // job1.Display();
        // job2.Display();

        Resume resume = new Resume();
        resume._name = "Moroni Aguilera";
        resume._jobs = new List<Job>();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }
}