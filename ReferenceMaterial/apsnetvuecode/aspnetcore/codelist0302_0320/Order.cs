namespace codelist0302_0320;

public class Order
{
    public int Id { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
    public string? Remark { get; set; }
}