using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2021;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Architect";
        job2._company = "Microsoft";
        job2._startYear = 2010;
        job2._endYear = 2020;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "Connor Hobbs";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}

