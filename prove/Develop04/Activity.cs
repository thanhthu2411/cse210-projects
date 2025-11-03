

public class Activity
{
    protected string _name;
    protected int _duration;
    protected string _welcomeMessage;
    protected bool _isRunning = true;

    public Activity(string name, string welcome)
    {
        _name = name;
        _welcomeMessage = welcome;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine(_welcomeMessage);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
    }

    // public bool IsTimeUp()
    // {
    //     DateTime 
    // }

    public void PauseWithSpinner(int seconds)
    {
        // Console.WriteLine(message);

        List<string> animationString = new List<string>() { "|", "/", "-", "\\" };

        for (int i = 0; i < seconds; i++)
        {
            Console.Write(animationString[i % 4]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PauseWithNumber(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PauseWithAnimation(int seconds)
    {
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
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
    }

    // welcome message, get ready message
    public void DisplayBeginningPart()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        DisplayWelcomeMessage();
        SetDuration();
        Console.Clear();

        Console.WriteLine("Get ready...");
        PauseWithSpinner(5);
    }

    // well-done, ending messages
    public void DisplayEndingPart()
    {
        Console.WriteLine("\nWell done!!");
        PauseWithSpinner(5);
        DisplayEndingMessage();
        PauseWithSpinner(5);
        Console.Clear();
    }

}