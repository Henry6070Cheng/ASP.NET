namespace codelist0302_0320;

public class Product
{
    public int Id { get; set; }
    public Category? Category { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
}