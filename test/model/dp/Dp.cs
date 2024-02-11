namespace test;

public class Dp
{
    private int _id;
    private Enum _type;
    private String _name;
    private List<int> _useCatId;
    // Сделать value

    public Dp(Enum type, String name)
    {
        _type = type;
        _name = name;
    }

    public void AddCatId(List<int> catsId)
    {
        foreach (var i in catsId)
        {
            if (_useCatId.Contains(i))
            {
                Console.WriteLine("Категория уже добавлена");
            }
            else
            {
                _useCatId.Add(i);
            }
        }
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public Enum Type
    {
        get => _type;
        set => _type = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
}