using ProgrammingInCSharp0407.Panel.Interfaces;
using ProgrammingInCSharp0407.Panel.Models;

namespace ProgrammingInCSharp0407.Panel.Services;

internal class ProductService : BaseService<Product>
{
    List<Product> products = new List<Product>();
    public void Add(Product product)
    {
        products.Add(product);
    }

    public List<Product> GetAll()
    {
        return products;
    }
}
