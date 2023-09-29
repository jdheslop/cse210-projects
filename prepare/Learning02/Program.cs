using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Tester";
        job1._company = "Adobe";
        job1._startYear = 2015;
        job1._endYear = 2020;
        

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Amazon";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Mitch Major";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}