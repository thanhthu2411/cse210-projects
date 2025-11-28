using System;

class Program
{
    static void Main(string[] args)
    {
        Running r1 = new Running(4.8, "27 Nov 2025", 30, "Running");
        Cycling c1 = new Cycling(9.2, "24 Nov 2025", 20, "Cycling");
        Swimming s1 = new Swimming(3, "30 Nov 2025", 40, "Swimming");

        List<Activity> activities = new List<Activity>() {r1, c1, s1};

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}