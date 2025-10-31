using PogrammingInCSharp.BaseBackend.Interfaces;
using PogrammingInCSharp.BaseBackend.Models;

namespace PogrammingInCSharp.BaseBackend.Services;

public class ProductService : BaseService<Product>
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
