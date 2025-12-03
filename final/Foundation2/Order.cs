
public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer cus, List<Product> products)
    {
        _customer = cus;
        _products = products;
    }

    public int GetShippingCost()
    {
        if (_customer.IsLivingInUsa())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double OrderTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }

        return total + GetShippingCost();
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