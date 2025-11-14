using PogrammingInCSharp.BaseBackend.Abstarctions;
using PogrammingInCSharp.BaseBackend.Enums;

namespace PogrammingInCSharp.BaseBackend.Models;

public class Order : BaseEntity
{
    public Order() :base()
    {

    }

    public List<OrderItem> OrderItems { get; set; }
 
    public User User { get; set; }
    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; }
    public OrderStatus Status { get; set; }

    public Address? Address { get; set; }
    public DateTime? SendAt { get; set; }
    public string? DeliveryPhoneNumber { get; set; }
    public string? DeliveryFullName { get; set; }
}
