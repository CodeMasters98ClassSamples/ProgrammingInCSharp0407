using ProgrammingInCSharp0407.Panel.Abstarctions;

namespace ProgrammingInCSharp0407.Panel.Models;

internal class WatchList : BaseEntity
{
    public WatchList(): base()
    {

    }

    public User User { get; set; }
    public Product Product { get; set; }
    public string Description { get; set; }
}
