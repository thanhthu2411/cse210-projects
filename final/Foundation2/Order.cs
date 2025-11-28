
public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private int _shippingCost;

    public Order(Customer cus, List<Product> products)
    {
        _customer = cus;
        _products = products;
    }

    public void SetShippingCost()
    {
        if (_customer.IsLivingInUsa())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
    }

    public double OrderTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }

        return total + _shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";

        foreach (Product p in _products)
        {
            label += $"{p.GetProId()} - {p.GetProName()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetCusName()}\n{_customer.GetCusAddress()}";
    }

}