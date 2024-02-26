namespace test;

public class Status(string name, bool isTerminal)
{
    private int _id;

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

    public bool IsTerminal
    {
        get => isTerminal;
        set => isTerminal = value;
    }
}