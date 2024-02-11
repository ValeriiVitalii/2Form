namespace test;

public class User
{
    private int _id;
    private String _name;
    private String _login;
    private String _password;
    //public User(int id) => _id

    public User(String name, String login, String password)
    {
        _name = name;
        _login = login;
        _password = password;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Login
    {
        get => _login;
        set => _login = value ?? throw new ArgumentNullException(nameof(value));
    }
}