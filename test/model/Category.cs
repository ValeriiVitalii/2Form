namespace test;

public class Category(String name, List<DpWithoutValue> dps, Dictionary<Status, List<int>> transitions)
{
    private int _id;
    private Dictionary<Status, List<int>> _transitions = transitions; //Ключ - статус, вэлью - id статусов доступных для перехода

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<DpWithoutValue> Dps        //Мб изменить SET
    {
        get => dps;
        set => dps = value ?? throw new ArgumentNullException(nameof(value));
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