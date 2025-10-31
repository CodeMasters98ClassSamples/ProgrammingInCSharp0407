using PogrammingInCSharp.BaseBackend.Abstarctions;

namespace PogrammingInCSharp.BaseBackend.Models;

public class Product : BaseEntity 
{
    public Product():base() { }

    public Product(string name,string code)
    {
        Name = name;
        Code = code;
    }
    
    public string Name { get; set; }
    public string Code { get; set; }
    public string Publisher { get; set; }
    public string Auther { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsSellable { get; set; }
}
