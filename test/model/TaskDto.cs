namespace test;

public class TaskDto(string name, string description, Status status)
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

    public string Description
    {
        get => description;
        set => description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Status Status
    {
        get => status;
        set => status = value ?? throw new ArgumentNullException(nameof(value));
    }
}