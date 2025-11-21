using PogrammingInCSharp.BaseBackend.Interfaces;
using PogrammingInCSharp.BaseBackend.Models;

namespace PogrammingInCSharp.BaseBackend.Services;

public class ProductService : IBaseService<Product>
{
    List<Product> products = new List<Product>();
    public void Add(Product product)
    {
        products.Add(product);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return products;
    }

    public void Update(Product item)
    {
        throw new NotImplementedException();
    }
}
