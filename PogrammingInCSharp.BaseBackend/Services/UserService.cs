using PogrammingInCSharp.BaseBackend.Interfaces;
using PogrammingInCSharp.BaseBackend.Models;

namespace PogrammingInCSharp.BaseBackend.Services;

public class UserService : BaseService<User>
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
