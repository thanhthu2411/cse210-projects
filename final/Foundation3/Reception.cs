
public class Reception : Event
{
    private string _email;

    public Reception(string email, string title,
                    string des, string date, string time, Address address, string type) : base(title, des, date, time, address, type)
    {
        _email = email;
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nEmail: {_email}\nType: Reception";
    }
}