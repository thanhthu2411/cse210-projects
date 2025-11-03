
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

// void DisplayProgressBar(double f)
// {
//     if (f < 0.1)
//     {
//         Console.WriteLine("[----------] 0%");
//     }
//     else if (f < 0.3)
//     {
//         Console.WriteLine("[-------###] 30%");
//     }
//     else if (f < 0.6)
//     {
//         Console.WriteLine("[----######] 60%");
//     }
//     else if (f < 0.9)
//     {
//         Console.WriteLine("[-#########] 90%");
//     }
//     else if (f == 1.0)
//     {
//         Console.WriteLine("[##########] 100%");
//     }
// }


// DateTime startTime = DateTime.Now;
// DateTime futureTime = startTime.AddSeconds(20);

// // Console.WriteLine($"{startTime} - {futureTime}");


// while (DateTime.Now < futureTime)
// {
//     // time progress bar
//     TimeSpan remaining = futureTime - DateTime.Now;
//     int remainingSeconds = remaining.Seconds;
//     DisplayProgressBar((double)remainingSeconds / 20.0);
// }

//[>------<]


// Console.WriteLine(message);

int seconds = 10;

string greater = ">";
string less = "<";
string s = new string('-', 10);

string animation = "[>----------<]";
string animation3 = "[ >--------< ]";
string animation4 = "[  >------<  ]";
string animation2 = $"[{greater}----------{less}]";

string[] characters = { "[", ">", "-", "-", "-", "-", "-", "-", "-", "-", "<", "]" };
// int greaterIdx = Array.IndexOf(characters, ">");
// int lessIdx = Array.IndexOf(characters, "<");

Console.Write(string.Join("", characters));

for (int i = 0; i < seconds; i++) // timer
{
    int greaterIdx = Array.IndexOf(characters, ">");
    int lessIdx = Array.IndexOf(characters, "<");

    if (greaterIdx == lessIdx - 1)
    {
        characters[greaterIdx] = "-";
        characters[lessIdx] = "-";
        characters[1] = ">";
        characters[characters.Length - 2] = "<";
    }

    else if (greaterIdx < characters.Length / 2 && lessIdx > characters.Length / 2)
    {
        characters[greaterIdx] = "-";
        characters[greaterIdx + 1] = ">";
        characters[lessIdx] = "-";
        characters[lessIdx - 1] = "<";

    }
    
    Console.Write(new string('\b', characters.Length));
    Console.Write(string.Join("", characters));
    Thread.Sleep(1000);

}