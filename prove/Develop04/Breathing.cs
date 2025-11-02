
public class BreathingActivity : Activity
{
    private int _breathIn;
    private int _breathOut;
    // private List<string> _instructions = new List<string>() { "Breathe in...", "Now breathe out..." };

    public BreathingActivity(int breathIn, int breathOut, string name, string welcome) : base(name, welcome)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    public void DisplayInstructions()
    {

        Console.WriteLine();
        Console.Write("Breath in...");
        PauseWithNumber(_breathIn);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        PauseWithNumber(_breathOut);
        Console.WriteLine();

    }

    public void Run()
    {
        DisplayBeginningPart();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        //instructions
        while (DateTime.Now < futureTime)
        {
            DisplayInstructions();
        }

        _isRunning = false;
        DisplayEndingPart();

    }
}