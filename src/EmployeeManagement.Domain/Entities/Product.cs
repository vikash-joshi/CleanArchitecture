namespace ProductCatalog.Domain.Entities;


public class Product
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public decimal Price { get; private set; }

    public int StockQuantity { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    private Product()
    {
        // Required by EF Core later
    }

    public Product(
        string name,
        string description,
        decimal price,
        int stockQuantity)
    {
        Id = Guid.NewGuid();

        Name = name;

        Description = description;

        Price = price;

        StockQuantity = stockQuantity;

        CreatedAt = DateTime.UtcNow;
    }
}