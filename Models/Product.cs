namespace WebApplication8.Models;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string? ProductCategory { get; set; }
    public double Price { get; set; }
    public double TaxRate { get; set; }
}