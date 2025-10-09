namespace Test;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        entry._entryDateTime = "Oct 6 2025";
        entry._givenPromtp = "..";
        entry._entryText = "abc";

        Journal journal = new Journal();
        journal.Initializer();
        journal.AppendEntry(entry);
        journal.DisplayJournal();
    }
}
