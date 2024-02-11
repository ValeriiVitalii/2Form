namespace test;

public class DpNumeric : Dp
{
    private int _value;

    public DpNumeric(Enum type, String name, int value) : base(type, name)
    {
        _value = value;
    }

    public int Value
    {
        get => _value;
        set => _value = value;
    }
}