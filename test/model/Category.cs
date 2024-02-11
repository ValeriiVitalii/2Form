namespace test;

public class Category
{
    private int _id;
    private String _name;
    private List<Dp> _dps;

    public Category(int id, String name, List<Dp> dps)
    {
        _name = name;
        _dps = dps;
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

    public List<Dp> Dps        //Мб изменить SET
    {
        get => _dps;
        set => _dps = value ?? throw new ArgumentNullException(nameof(value));
    }
}