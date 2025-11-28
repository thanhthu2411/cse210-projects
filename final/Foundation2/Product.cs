
public class Product
{
    private string _proName;
    private int _proId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quanity)
    {
        _proName = name;
        _proId = id;
        _price = price;
        _quantity = quanity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string GetProName()
    {
        return _proName;
    }

    public int GetProId()
    {
        return _proId;
    }
}