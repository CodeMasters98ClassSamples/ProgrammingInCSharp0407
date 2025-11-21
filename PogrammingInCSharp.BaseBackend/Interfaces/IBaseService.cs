namespace PogrammingInCSharp.BaseBackend.Interfaces;

public interface IBaseService<T>
{
    void Update(T item);
    void Delete(int id);
    void Add(T item);
    List<T> GetAll();
}
