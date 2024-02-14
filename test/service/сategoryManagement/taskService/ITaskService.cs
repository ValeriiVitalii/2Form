namespace test.taskService;

public interface ITaskService
{
    internal void addTask(string name, string description, Status status, int catId);

    internal TaskDto getTask(int taskId, int userId);
    
    internal int removeTask(int id);
}