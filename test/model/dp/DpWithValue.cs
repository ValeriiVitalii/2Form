namespace test;

public class DpWithValue(TypeDp type, String name) : DpWithoutValue(type, name)
{
    private int _id;

    private object _value;

    private int _taskId;
    
    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public object Value
    {
        get => _value;
        set => _value = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int TaskId
    {
        get => _taskId;
        set => _taskId = value;
    }
}