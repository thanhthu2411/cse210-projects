using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {

        bool isRunning = true;
        // load scriptures from "scriptures.csv"
        string[] lines = System.IO.File.ReadAllLines("scriptures.csv");
        Console.Write("Start verse: ");
        int startVer = int.Parse(Console.ReadLine());

        Console.Write("End verse: ");
        int endVer = int.Parse(Console.ReadLine());

        if (endVer > lines.Length)
        {
            Console.WriteLine($"Verse {endVer} not availabe");
            return;
        }
        else if (startVer < 1)
        {
            Console.WriteLine($"Verse {startVer} not availabe");
            return;
        }
        else if (startVer > endVer)
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        // reference
        Reference reference1 = new Reference("Jacob", "1", startVer, endVer);
        string text = GetTextFromReference(lines, reference1);
        Scripture scripture = new Scripture(reference1, text);

        // running
        while (isRunning)
        {
            scripture.DisplayScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string action = Console.ReadLine().Trim();
            if (action == "quit")
            {
                isRunning = false;
            }
            else if (action == "")
            {
                Console.Clear();
                scripture.HideRandomWords();
                // scripture.DisplayScripture();
            }

            if (scripture.AllWordsHidden())
            {
                isRunning = false;
            }

        }

    }

    static string GetTextFromReference(string[] lines, Reference reference)
    {
        int startVer = reference.GetStartVer();
        int endVer = reference.GetEndVer();
        List<string> textList = new List<string>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            int verse = int.Parse(parts[0]);
            string text = parts[1];
            textList.Add(text);
        }

        if (startVer == endVer)
        {
            return textList[startVer - 1];
        }
        else if (startVer < endVer)
        {

            string text = "";
            for (int i = startVer - 1; i < endVer; i++)
            {
                text += textList[i] + " ";
            }
            return text;
        }
        else
        {
            return "";
        }
    }


}

// To exceed requirements, I loaded scriptures from the file "scriptures.csv", and let users
// type the start verse and end verse.