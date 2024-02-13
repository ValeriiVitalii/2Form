using test.userService;

namespace test.service.userService;

public class UserServiceDao : IUserService
{
    private Storage _storage = new Storage();

    public int addUser(String name, String login, String password)
    {
        var user = new User(name, login, password);

        return _storage.addUser(user);
    }

    public int removeUser(int userId)
    {
        return _storage.removeUser(userId);
    }
}