using ProgrammingInCSharp0407.Panel.Interfaces;
using ProgrammingInCSharp0407.Panel.Models;

namespace ProgrammingInCSharp0407.Panel.Services;

internal class UserService : BaseService<User>
{
    List<User> users = new();

    public void Add(User user)
    {
        users.Add(user);
    }

    public List<User> GetAll()
    {
        return users;
    }
}
