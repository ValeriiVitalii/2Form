namespace test;

public class DpFile : Dp
{
    private String[] _value;

    public DpFile(Enum type, String name, String[] value) : base(type, name)
    {
        _value = value;
    }

    public String[] Value
    {
        get => _value;
        set => _value = value ?? throw new ArgumentNullException(nameof(value));
    }
}