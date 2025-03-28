using System;
using System.Collections.Generic;

public class Resume
{
    private string _name;
    private List<Job> _jobs;

    public Resume(string name)
    {
        _name = name;
        // initialize the list in the constructor
        _jobs = new List<Job>(); 
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"{_name}");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}