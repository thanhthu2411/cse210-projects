
public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string title,
                    string des, string date, string time, Address address, string type) : base(title, des, date, time, address, type)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nWeather: {_weather}\nType: Outdoor";
    }
}