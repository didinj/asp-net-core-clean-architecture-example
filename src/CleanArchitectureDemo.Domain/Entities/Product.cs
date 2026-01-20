namespace CleanArchitectureDemo.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    private Product() { } // For ORM compatibility (not ORM-dependent)

    public Product(string name, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name cannot be empty.");

        if (price <= 0)
            throw new ArgumentException("Price must be greater than zero.");

        Id = Guid.NewGuid();
        Name = name;
        Price = price;
    }

    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentException("Price must be greater than zero.");

        Price = newPrice;
    }
}
