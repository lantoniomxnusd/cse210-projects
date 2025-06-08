using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string result = "Packing Label: \n";
        foreach (Product product in _products)
        {
            result += product.GetPackingLabel() + "\n";
        }

        return result;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? 5.0 : 35.0;
        return total;
    }
}