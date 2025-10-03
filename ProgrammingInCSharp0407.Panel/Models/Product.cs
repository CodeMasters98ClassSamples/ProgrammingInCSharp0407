using ProgrammingInCSharp0407.Panel.Abstarctions;

namespace ProgrammingInCSharp0407.Panel.Models;

internal class Product : BaseEntity 
{
    
    public string Name { get; set; }
    public string Code { get; set; }
    public string Publisher { get; set; }
    public string Auther { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsSellable { get; set; }
}
