using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _StartYear;
    public int _endYear;

    public void Dispay()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_StartYear}-{_endYear}");
    }

}