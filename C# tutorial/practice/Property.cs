using System;
using System.Collections;
using System.Collections.Generic;

public class Product
{
    private decimal _price;

    public int Id { get; private set; }
    public string Name { get; set; }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value <= 0)
                throw new ArgumentException("positive");
                _price = value;
        }
    }

    public decimal Tax => Price * 0.18m;
    public DateTime CreatedAt { get; protected set; }
    public string InternalCode { get; internal set; }
    public string Category { get; init; }
    private string SecretTag { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
        CreatedAt = DateTime.Now;
        SecretTag = "SYS";
    }

    protected void UpdateCreatedTime()
    {
        CreatedAt = DateTime.Now;
    }
}

internal class ProductCatalog : IEnumerable<Product>
{
    private List<Product> _products = new List<Product>();

    public void Add(Product p)
    {
        _products.Add(p);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        foreach (var p in _products)
            yield return p;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Product> GetExpensiveProducts(decimal minPrice)
    {
        foreach (var p in _products)
            if (p.Price >= minPrice)
                yield return p;
    }
}

class Property
{
    public static void Main()
    {
        var p1 = new Product(1, "Laptop", 60000)
        {
            Category = "Electronics",
            InternalCode = "INT-001"
        };

        var p2 = new Product(2, "Chair", 3000)
        {
            Category = "Furniture",
            InternalCode = "INT-002"
        };

        var catalog = new ProductCatalog();
        catalog.Add(p1);
        catalog.Add(p2);

        Console.WriteLine("FOREACH");
        foreach (var p in catalog)
        {
            Console.WriteLine($"{p.Name} | Price: {p.Price} | Tax: {p.Tax}");
        }

        Console.WriteLine("FILTERED");
        foreach (var p in catalog.GetExpensiveProducts(10000))
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine("MANUAL ENUMERATOR");
        var enumerator = catalog.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current.Name);
        }
    }
}