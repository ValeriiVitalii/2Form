using test.dpService;

namespace test;

public class User(String name, String login, String password)
{
    private int _id;
    private String _password = password;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Login
    {
        get => login;
        set => login = value ?? throw new ArgumentNullException(nameof(value));
    }
}