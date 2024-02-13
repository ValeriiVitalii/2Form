namespace test;

public class Dp(Enum type, String name)
{
    private int _id;

    private List<int> _useCatId;
    // Сделать value

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
        get => type;
        set => type = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
}