
public class ListingActivity : Activity
{
    private Prompts _prompts;
    private List<string> _userInput = new List<string>();

    public ListingActivity(Prompts prompts, string name, string welcome) : base(name, welcome)
    {
        _prompts = prompts;
    }

    public void DisplayRandomPrompt()
    {
        Console.WriteLine("List as many response you can to the following prompt: ");
        Console.WriteLine($"--- {_prompts.ChooseRandomPrompt()} ---");
        Console.WriteLine();
    }

    public int CountInput()
    {
        return _userInput.Count;
    }

    public void Run()
    {
        DisplayBeginningPart();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DisplayRandomPrompt();
        Console.Write("You may begin in: ");
        PauseWithNumber(4);
        Console.WriteLine();

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input.Trim() != "")
            {
                _userInput.Add(input);

            }
        }

        _isRunning = false;
        Console.WriteLine($"You listed {CountInput()} items!");

        DisplayEndingPart();
    }

}