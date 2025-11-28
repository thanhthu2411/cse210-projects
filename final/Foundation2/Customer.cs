
public class Customer
{
    private string _cusName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _cusName = name;
        _address = address;
    }

    public bool IsLivingInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetCusName()
    {
        return _cusName;
    }

    public string GetCusAddress()
    {
        return _address.GetAddressString();
    }
}