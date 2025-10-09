class Journal
{
    public List<Entry> _entries;
    public void Initializer()
    {
        _entries = new();
    }
    public void AppendEntry(Entry e)
    {
        _entries.Add(e);
    }

    public void DisplayJournal()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }
}