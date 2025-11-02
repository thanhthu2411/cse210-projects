
// List<string> prompts = new List<string>()
//         {
//             "Think of a time when you stood up for someone else.",
//             "Think of a time when you did something really difficult.",
//             "Think of a time when you helped someone in need.",
//             "Think of a time when you did something truly selfless."
//         };

// List<string> usedPrompts = new List<string>();

// Random random = new Random();


// string ChooseRandomPrompt()
// {

//     if (usedPrompts.Count == prompts.Count)
//     {
//         usedPrompts.Clear();
//     }

//     string randomPrompt;

//     do
//     {
//         int i = random.Next(prompts.Count);
//         randomPrompt = prompts[i];

//     } while (usedPrompts.Contains(randomPrompt));

//     usedPrompts.Add(randomPrompt);
//     return randomPrompt;
// }

// for (int i =0; i < 6; i++)
// {
//     Console.WriteLine(ChooseRandomPrompt());
// }

void DisplayProgressBar(double f)
{
    if (f < 0.1)
    {
        Console.WriteLine("[----------] 0%");
    }
    else if (f < 0.3)
    {
        Console.WriteLine("[-------###] 30%");
    }
    else if (f < 0.6)
    {
        Console.WriteLine("[----######] 60%");
    }
    else if (f < 0.9)
    {
        Console.WriteLine("[-#########] 90%");
    }
    else if (f == 1.0)
    {
        Console.WriteLine("[##########] 100%");
    }
}


DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(20);

// Console.WriteLine($"{startTime} - {futureTime}");


while (DateTime.Now < futureTime)
{
    // time progress bar
    TimeSpan remaining = futureTime - DateTime.Now;
    int remainingSeconds = remaining.Seconds;
    DisplayProgressBar((double)remainingSeconds / 20.0);
}