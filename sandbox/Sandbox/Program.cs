using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!".ToUpper());
        // Console.Write("What?");
        // string color = Console.ReadLine();
        string words = "hello sandbox world!";
        TextInfo textInfor = CultureInfo.CurrentCulture.TextInfo;
        string capitalized = textInfor.ToTitleCase(words);
        Console.WriteLine(capitalized);


    }
}