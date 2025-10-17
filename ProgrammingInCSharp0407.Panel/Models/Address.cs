using ProgrammingInCSharp0407.Panel.Abstarctions;

namespace ProgrammingInCSharp0407.Panel.Models;

internal class Address : BaseEntity
{
    public Address()
    {
        CreatedAt = DateTime.Now;
    }

    public string Name { get; set; }
    public string PostalCode { get; set; }
}
