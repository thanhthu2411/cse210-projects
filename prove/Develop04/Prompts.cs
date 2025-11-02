
public class Prompts
{
    private List<string> _prompts = new List<string>();
    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();

    public Prompts(List<string> strings)
    {
        _prompts = strings;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public string ChooseRandomPrompt()
    {

        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string randomPrompt;

        do
        {
            int i = _random.Next(_prompts.Count);
            randomPrompt = _prompts[i];

        } while (_usedPrompts.Contains(randomPrompt));

        _usedPrompts.Add(randomPrompt);
        return randomPrompt;
    }


}