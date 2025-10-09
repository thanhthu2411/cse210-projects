using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _promtps = new List<string>();
    public int _entryCounter;
    public string _latestUpdate;

    public void DisplayJournal()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Entry entry = _entries[i];
            Console.Write($"{i + 1} - ");
            entry.DisplayEntry();
        }

    }

    public void DisplayExtraInfor()
    {
        Console.WriteLine($"Number of entries: {CountEntry()}");
        Console.WriteLine($"Latest update: {FindLatestUpdate()}");

    }

    //save journals
    public void Save()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        if (!filename.EndsWith(".csv"))
        {
            filename += ".csv";
        }

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._prompt}|{e._content}");
            }
        }
    }

    //load file
    public void Load()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");


            string date = parts[0];
            string prompt = parts[1];
            string content = parts[2];

            //new Entry object
            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._content = content;

            //add new entry to the list
            _entries.Add(entry);

        }

    }

    //Write new entry
    public void Write()
    {
        DateTime currentTime = DateTime.Now;
        string entryDate = currentTime.ToShortDateString();
        string prompt = GeneratePrompt();
        Console.WriteLine($"Date: {entryDate} - Prompt: {prompt}");
        string content = Console.ReadLine();

        //new Entry object
        Entry entry = new Entry();
        entry._date = entryDate;
        entry._prompt = prompt;
        entry._content = content;

        //add new entry to the list
        _entries.Add(entry);
    }

    //Generate prompt for each entry
    public string GeneratePrompt()
    {
        Random random = new Random();
        int i = random.Next(_promtps.Count);

        string randomPrompt = _promtps[i];
        return randomPrompt;
    }

    // count the number of entries
    public int CountEntry()
    {
        _entryCounter = _entries.Count;

        return _entryCounter;
    }

    // find the latest update
    public string FindLatestUpdate()
    {
        DateTime latestDate = DateTime.MinValue;

        foreach (Entry e in _entries)
        {
            DateTime entryDate = DateTime.Parse(e._date);
            if (entryDate > latestDate)
            {
                latestDate = entryDate;
            }
        }

        return latestDate.ToString("MM/dd/yyyy");
    }

    // edit a specific entry
    public void Edit()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entry to edit");
            return;

        }

        DisplayJournal();

        Console.WriteLine("Which entry do you want to edit? ");
        int answer = int.Parse(Console.ReadLine());

        if (answer >= _entries.Count + 1)
        {
            Console.WriteLine("Entry doesn't exist.");
            return;
        }
        else
        {
            Entry editedEntry = _entries[answer - 1];
            Console.WriteLine($"Here is your prompt: {editedEntry._prompt}\n Here is your response: {editedEntry._content}\nPlease enter your update: ");
            string change = Console.ReadLine();

            editedEntry._content = change;

        }
    }


}