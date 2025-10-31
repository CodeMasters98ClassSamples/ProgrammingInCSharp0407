using PogrammingInCSharp.BaseBackend.Abstarctions;

namespace PogrammingInCSharp.BaseBackend.Models;

public class Address : BaseEntity
{
    public Address()
    {
        CreatedAt = DateTime.Now;
    }

    public string Name { get; set; }
    public string PostalCode { get; set; }
}
