namespace test;

public class Category(String name, List<Dp> dps, Dictionary<Status, List<int>> transitions)
{
    private int _id;
    private String _name = name;
    private List<Dp> _dps = dps;
    private Dictionary<Status, List<int>> _transitions = transitions; //Ключ - статус, вэлью - id статусов доступных для перехода

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

    public void addStatus(Status status, List<int> ids)
    {
        _transitions.Add(status, ids);  //Не сделал в дефолтном сеттере ибо тогда нужно будет подавать в метод мапу         
    }
    
    public void addTransitions(Status status, List<int> ids)
    {
        foreach (var id in ids)
        {
            _transitions[status].Add(id);
        }
    }
}