namespace test;

public class Storage
{
    private Dictionary<int, User> _users = new Dictionary<int, User>();

    private Dictionary<int, Category> _categories = new Dictionary<int, Category>();

    private Dictionary<int, DpWithoutValue> _dpsWithoutValue = new Dictionary<int, DpWithoutValue>();
    
    private Dictionary<int, DpWithValue> _dpsWithValue = new Dictionary<int, DpWithValue>();

    private Dictionary<int, Status> _statuses = new Dictionary<int, Status>();
    
    private Dictionary<int, Task> _tasks = new Dictionary<int, Task>();
    
    

    private int _userId = 1;
    
    private int _categoryId = 1;
    
    private int _dpWithoutValueId = 1;
    
    private int _dpWithValueId = 1;

    private int _statusId = 1;
    
    private int _taskId = 1;


    public int addUser(User user)
    {
        user.Id = _userId;
        _users.Add(_userId, user);  
        return _userId++;
    }

    public int removeUser(int userId)
    {
        _users.Remove(userId);
        return userId;
    }

    
    public int addCategory(Category category)
    {
        _categories.Add(_categoryId, category);
        return _categoryId++;
    }

    public int removeCategory(int categoryId)
    {
        _categories.Remove(categoryId);
        return categoryId;
    }
    

    public int addDpWithoutValue(DpWithoutValue dpWithoutValue)
    {
        _dpsWithoutValue.Add(_dpWithoutValueId, dpWithoutValue);
        return _dpWithoutValueId++;
    }

    public DpWithoutValue getDp(int dpId)
    {
        return _dpsWithoutValue[dpId];
    }
    
    public int addDpWithValue(DpWithValue dpWithValue)
    {
        _dpsWithValue.Add(_dpWithValueId, dpWithValue);
        return _dpWithValueId++;
    }

    public int removeDp(int dpId)
    {
        _dpsWithoutValue.Remove(dpId);
        return dpId;
    }

    public int addTask(Task task)
    {
        _tasks.Add(_taskId, task);
        return _taskId;
    }

    public int removeTask(int taskId)
    {
        _tasks.Remove(taskId);
        return taskId;
    }
}