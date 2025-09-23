using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int num;
        int sum=0;
        int average;
        List<int> numbers = new List<int>();
        string number;

        do
        {
            Console.Write("Number: ");
            number = Console.ReadLine();
            num = int.Parse(number);
            numbers.Add(num);
        }
        while (num != 0);

        numbers.Remove(0);

        foreach (int i in numbers)
        {
            sum = sum + i;
        }

        average = sum / numbers.Count;
        int max = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"The largest number: {max}");
        

    }
}