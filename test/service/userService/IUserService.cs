namespace test.userService;

public interface IUserService
{
    internal int addUser(String name, String login, String password);

    internal int removeUser(int userId);
}