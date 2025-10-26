using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Anna", "Fraction", "7.3", "8-19");
        WritingAssignment writing1 = new WritingAssignment("Harry", "Counter-argument", "Happiness");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

    }
}