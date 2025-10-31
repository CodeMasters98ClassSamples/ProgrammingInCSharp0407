namespace PogrammingInCSharp.BaseBackend.Abstarctions;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        CreatedAt = DateTime.Now;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
}
