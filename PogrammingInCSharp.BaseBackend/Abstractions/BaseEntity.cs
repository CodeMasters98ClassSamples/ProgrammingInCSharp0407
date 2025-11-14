namespace PogrammingInCSharp.BaseBackend.Abstarctions;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        CreatedAt = DateTime.Now;
    }

    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
}
