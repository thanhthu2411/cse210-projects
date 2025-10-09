class Entry
{
    public string _givenPromtp;
    public string _entryDateTime;
    public string _entryText;

    //behaviors
    public void DisplayEntry()
    {
        Console.WriteLine($"{_entryDateTime} - {_givenPromtp} {_entryText}");
    }
}