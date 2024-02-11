namespace test;

public class DpText : Dp
{
    private String _value;

    public DpText(Enum type, string name, String value) : base(type, name)
    {
        _value = value;
    }
    
    public string Value
    {
        get => _value;
        set => _value = value ?? throw new ArgumentNullException(nameof(value));
    }
}