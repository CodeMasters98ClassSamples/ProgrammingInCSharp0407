namespace PogrammingInCSharp.BaseBackend.Interfaces;

public interface IBaseService<T>
{
    void Add(T item);
    List<T> GetAll();
}
