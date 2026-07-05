namespace ProductManagement.Application.DTOs;

public sealed class CreateProductRequest
{
    public string Name { get; init; } = string.Empty;

    public string Description { get; init; } = string.Empty;

    public decimal Price { get; init; }

    public string Currency { get; init; } = "INR";

    public int StockQuantity { get; init; }
}