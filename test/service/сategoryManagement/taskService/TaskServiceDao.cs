using test.service.сategoryManagement;
using test.service.сategoryManagement.dpService;

namespace test.taskService;

public class TaskServiceDao : ITaskService
{
    private readonly Storage _storage = new Storage();
    private readonly DpWithoutValueServiceDao _dpWithoutValueService = new DpWithoutValueServiceDao();
    private readonly DpWithValueServiceDao _dpWithValueService= new DpWithValueServiceDao();
    private readonly StatusServiceDao _statusService = new StatusServiceDao();
    
    public void addTask(string name, string description, Status status, int catId)
    {
        int statusId = _statusService.createStatus("Новая", false); //Позже удалить
        
        Task task = new Task(name, description,_statusService.getStatus(statusId) , 1);
        IEnumerable<DpWithoutValue> dpsFromCategory = _dpWithoutValueService.getDpByCatId(catId);

        int taskId = _storage.addTask(task); 
        _dpWithValueService.addDpWithValueAfterAddTask(dpsFromCategory, taskId); 
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

    /*public int setStatus(int taskId, int statusId)    //Доделать 2 метода, сделать проверку fill
    {
        
    }

    public List<int> getAvailableStatusId(int taskId, int statusId)
    {
        
    }*/
}