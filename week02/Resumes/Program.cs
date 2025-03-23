using System;

class Program
{
    static void Main(string[] args)
    {
    
    Resume resume = new Resume("John Doe");

        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        resume.AddJob(job1);
        resume.AddJob(job2);

        resume.Display();    
    }
}