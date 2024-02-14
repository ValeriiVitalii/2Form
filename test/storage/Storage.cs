using System.Collections;
using test.utilityStaticClass;

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
        category.Id = _categoryId;
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
        dpWithoutValue.Id = _dpWithoutValueId;
        _dpsWithoutValue.Add(_dpWithoutValueId, dpWithoutValue);
        return _dpWithoutValueId++;
    }

    public DpWithoutValue getDpWithoutValue(int dpId)
    {
        return _dpsWithoutValue[dpId];
    }
    
    public List<DpWithoutValue> getDpsWithoutValue()
    {
        return _dpsWithoutValue.Values.ToList();
    }
    
    public DpWithValue getDpWithValue(int dpId)
    {
        return _dpsWithValue[dpId];
    }
    
    public int addDpWithValue(DpWithValue dpWithValue)
    {
        dpWithValue.Id = _dpWithValueId; 
        _dpsWithValue.Add(_dpWithValueId, dpWithValue);
        return _dpWithValueId++;
    }
    
    public void addDpWithValueAfterAddTask(IEnumerable<DpWithoutValue> dps, int taskId)
    {   //Сделал в storage потому что тут логика заполнения id
        dps.ToList().ForEach(dp => _dpsWithValue.Add(_dpWithValueId++, Mapper.toDpWithValue(dp, taskId)));
    }

    public int editDpValue(int dpId, object value)
    {
        _dpsWithValue[dpId].Value = value;
        return dpId;
    }

    public int removeDp(int dpId)
    {
        _dpsWithoutValue.Remove(dpId);
        return dpId;
    }

    public int addTask(Task task)
    {
        task.Id = _taskId;
        _tasks.Add(_taskId, task);
        return _taskId++;
    }
    
    public TaskDto getTask(int taskId)
    {
        return Mapper.toTaskDto(_tasks[taskId]);
    }

    public int removeTask(int taskId)
    {
        _tasks.Remove(taskId);
        return taskId;
    }
}