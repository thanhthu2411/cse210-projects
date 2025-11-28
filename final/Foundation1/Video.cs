
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public int CommentNumber()
    {
        return _comments.Count();
    }

    public void DisplayInfor()
    {
        Console.WriteLine($"TITLE: {_title.ToUpper()} \nAuthor: {_author}\nLength: {_length} seconds\nNumber of comments: {CommentNumber()}");
    }

    public void DisplayComments()
    {
        foreach(Comment c in _comments)
        {
            c.DisplayComment();
        }
    }
}