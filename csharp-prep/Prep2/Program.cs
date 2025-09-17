using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your grade percentage: ");
        string percentage = Console.ReadLine();

        int per = int.Parse(percentage);
        string letter = "";
        string sign = "";

        if (per >= 90)
        {
            letter = "A";
        }
        else if (per >= 80)
        {
            letter = "B";

        }
        else if (per >= 70)
        {
            letter = "C";

        }
        else if (per >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";
        }

        // sign for grades
        if (93 > per && per >= 60)
        {
            if (per % 10 >= 7)
            {
                sign = "+";
            }
            else if (per % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"{letter}{sign}");

        // pass or fail class
        if (per >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try harder!");
        }
    }
}