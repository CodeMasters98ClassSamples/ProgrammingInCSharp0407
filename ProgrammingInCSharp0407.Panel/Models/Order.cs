using ProgrammingInCSharp0407.Panel.Abstarctions;
using ProgrammingInCSharp0407.Panel.Enums;

namespace ProgrammingInCSharp0407.Panel.Models;

internal class Order : BaseEntity
{
    public Order() :base()
    {

    }

    public List<OrderItem> OrderItems { get; set; }
 
    public User User { get; set; }
    public DateTime CreatedAt { get; set; }
    public OrderStatus Status { get; set; }

    public Address? Address { get; set; }
    public DateTime? SendAt { get; set; }
    public string? DeliveryPhoneNumber { get; set; }
    public string? DeliveryFullName { get; set; }
}
