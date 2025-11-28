public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string des, string date, string time, Address address, string type)
    {
        _title = title;
        _description = des;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate & Time: {_date} at {_time}\nAddress: {_address.GetAddressString()}";
    }

    public string ShortDescription()
    {
        return $"Type: {_type}\nTitle: {_title}\nDate: {_date}";
    }

}