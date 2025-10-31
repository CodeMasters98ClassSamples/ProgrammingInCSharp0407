using PogrammingInCSharp.BaseBackend.Abstarctions;

namespace PogrammingInCSharp.BaseBackend.Models;

public class WatchList : BaseEntity
{
    public WatchList(): base()
    {

    }

    public User User { get; set; }
    public Product Product { get; set; }
    public string Description { get; set; }
}
