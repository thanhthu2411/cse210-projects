using System;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void ResumeDisplay()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job j in _jobs)
        {
            j.Dispay();
        }

    }
}