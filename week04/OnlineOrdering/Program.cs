using System;
using System.Collections.Generic;

// Address Class
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}

// Customer Class
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Name => _name;

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingAddress()
    {
        return _address.GetFullAddress();
    }
}

// Product Class
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}

// Order Class
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.GetShippingAddress()}";
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Create Addresses
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add Products to Order 1
        order1.AddProduct(new Product("Laptop", "A123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.99, 2));

        // Add Products to Order 2
        order2.AddProduct(new Product("Phone", "C789", 699.99, 1));
        order2.AddProduct(new Product("Charger", "D012", 19.99, 3));

        // Display Order 1 details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Display Order 2 details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}
