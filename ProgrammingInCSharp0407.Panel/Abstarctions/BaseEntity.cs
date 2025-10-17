namespace ProgrammingInCSharp0407.Panel.Abstarctions;

internal abstract class BaseEntity
{
    public BaseEntity()
    {
        CreatedAt = DateTime.Now;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
}
