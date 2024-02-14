namespace test;

public class DpWithoutValue(TypeDp type, String name)
{
    private int _id;

    private List<int> _useCatId = null!;
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

    public List<int> UseCatId
    {
        get => _useCatId;
        set => _useCatId = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public TypeDp Type
    {
        get => type;
        set => type = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
}