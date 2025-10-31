namespace PogrammingInCSharp.BaseBackend.Interfaces;

public interface BaseService<T>
{
    void Add(T item);
    List<T> GetAll();
}
