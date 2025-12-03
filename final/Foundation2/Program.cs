using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("Anna Snow",
            new Address("123 Maple Street", "Austin", "TX", "USA"));

        Customer c2 = new Customer("Nick Smith",
            new Address("87 Pine Ridge Ave", "Hanoi", "HA", "VN"));


        List<Product> pl1 = new List<Product>()
        {
            new Product("Wireless Mouse", 101, 19.99, 2),
            new Product("Mechanical Keyboard", 102, 59.50, 1)
        };

        List<Product> pl2 = new List<Product>()
        {
            new Product("USB-C Charging Cable", 103, 8.75, 3),
            new Product("Laptop Stand", 104, 27.40, 1)
        };

        Order o1 = new Order(c1, pl1);
        Order o2 = new Order(c2, pl2);

        List<Order> orderList = new List<Order>()
        {
            o1, o2
        };

        foreach(Order o in orderList)
        {
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"\nTotal Cost: ${Math.Round(o.OrderTotalCost(), 2)}");
            Console.WriteLine("\n----------------------");
        }
    }
}