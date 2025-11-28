
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title,
                    string des, string date, string time, Address address, string type) : base(title, des, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}\nType: Lecutre";
    }
}