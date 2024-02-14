using test.service.сategoryManagement.dpService;

namespace test.taskService;

public class TaskServiceDao : ITaskService
{
    private readonly Storage _storage = new Storage();
    private readonly DpWithoutValueServiceDao _dpWithoutValueServiceDao = new DpWithoutValueServiceDao();
    private readonly DpWithValueServiceDao _dpWithValueServiceDao = new DpWithValueServiceDao();
    
    public void addTask(string name, string description, Status status, int catId)
    {
        Task task = new Task(name, description, new Status("Новая", false), 1);
        IEnumerable<DpWithoutValue> dpsFromCategory = _dpWithoutValueServiceDao.getDpByCatId(catId);

        int taskId = _storage.addTask(task); 
        _dpWithValueServiceDao.addDpWithValueAfterAddTask(dpsFromCategory, taskId); 
        //Так же добавить получение дп и заполнение(сделать параметр bool fill)
    }
    
    public TaskDto getTask(int taskId, int userId)
    {
        return _storage.getTask(taskId);       //Сделать проверку юзера
    }

    public int removeTask(int taskId)
    {
        return _storage.removeTask(taskId);
    }
}