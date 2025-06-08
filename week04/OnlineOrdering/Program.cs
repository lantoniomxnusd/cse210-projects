using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Ignacio Ramirez 2580", "Guadalajara", "Jalisco", "Mexico");
        Customer customer1 = new Customer("Luis Antonio", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Weber Grill", "14401001", 219.00, 1));
        order1.AddProduct(new Product("Kingsford Charcoal Briquettes", "12345", 10.92, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("\n------------------\n");

        Address address2 = new Address("123 Star Dr.", "Moses Lake", "WA", "USA");
        Customer customer2 = new Customer("Maria Lopez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Milwaukee Hackzall", "2719-20", 122.99, 1));
        order2.AddProduct(new Product("10-piece Ultimate Saw Blade Set", "54321", 7.99, 4));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}