
public class Comment
{
    public string _commenter;
    public string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_text} by {_commenter}");
    }
}