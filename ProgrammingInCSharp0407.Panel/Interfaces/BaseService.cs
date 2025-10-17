namespace ProgrammingInCSharp0407.Panel.Interfaces;

internal interface BaseService<T>
{
    void Add(T item);
    List<T> GetAll();
}
