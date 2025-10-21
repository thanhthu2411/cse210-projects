
class Reference
{
    private string _book;
    private string _chapter;
    private int _startVer;
    private int _endVer;

    // methods
    public Reference(string book, string chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVer = start;
        _endVer = end;
    }

    public string DisplayReference()
    {

        if (_startVer == _endVer)
        {
            return $"{_book} {_chapter}:{_startVer}";

        }
        else if (_startVer > _endVer)
        {
            return "Invalid input";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVer}-{_endVer}";
        }
    }

    // getter methods
    public string GetBook()
    {
        return _book;
    }
    public string GetChapter()
    {
        return _chapter;
    }

    public int GetStartVer()
    {
        return _startVer;
    }
    public int GetEndVer()
    {
        return _endVer;
    }

    //setter methods
    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }
    public void SetStartVer(int start)
    {
        _startVer = start;
    }
    public void SetEndVer(int end)
    {
        _endVer = end;
    }
}