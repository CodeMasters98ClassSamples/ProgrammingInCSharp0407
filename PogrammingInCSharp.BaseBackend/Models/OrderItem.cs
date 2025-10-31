namespace PogrammingInCSharp.BaseBackend.Models;

public class OrderItem
{
    public Order Order { get; set; }
    public Product Product { get; set; }
    public decimal CurrentPrice { get; set; }
    public int Count { get; set; }
}
