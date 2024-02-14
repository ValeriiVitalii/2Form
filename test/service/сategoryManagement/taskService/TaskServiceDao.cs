namespace test.taskService;

public class TaskServiceDao : ITaskService
{
    private Storage _storage = new Storage();
    public int addTask(string name, string description, Status status, int catId)
    {
        Task task = new Task(name, description, new Status("Новая", false), 1);
        return _storage.addTask(task);  //Так же добавить получение зп и заполнение
    }

    public int removeTask(int taskId)
    {
        return _storage.removeTask(taskId);
    }
}