namespace test;

public class DpWithValue(TypeDp type, String name) : DpWithoutValue(type, name)
{
    private int _id;

    private object _value;

    private int _taskId;

    private bool _fill;
    
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

    public bool Fill
    {
        get => _fill;
        set => _fill = value;
    }
}