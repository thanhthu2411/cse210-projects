using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();

        int squaredNum = SquareNumber(userNum);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNum, birthYear);

    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");

    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;

    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        return userNumber;

    }


    static void PromptUserBirthYear(out int x)
    {
        Console.Write("Please enter the year you were born: ");
        string year = Console.ReadLine();
        x = int.Parse(year);
    }

    static int SquareNumber(int x)
    {
        return x * x;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
}

        
