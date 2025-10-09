using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Journal journal = new Journal();
        journal._entries = new List<Entry>();
        journal._entryCounter = 0;
        journal._latestUpdate = "";
        journal._promtps = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was your favorite general conference talk?",
            "What did you do to show kindness to others?",
            "How was your class/work today?"
        };

        while (running)
        {
            Console.Write("Please select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Edit\n6.Quit\nWhat would you like to do? ");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                journal.Write();
            }
            else if (answer == "2")
            {
                journal.DisplayJournal();
                journal.DisplayExtraInfor();
            }
            else if (answer == "3")
            {
                journal.Load();
            }
            else if (answer == "4")
            {
                journal.Save();
            }
            else if (answer == "6")
            {
                running = false;
            }
            else if (answer == "5")
            {
                journal.Edit();
            }
            else
            {
                Console.Write("Invalid input.");
            }
        }
    }
}

// For creativity, I added the Edit method for the Journal class, which allows users to make changes to their entries.
// I also add some methods to display the number of entries and when the latest update is made.