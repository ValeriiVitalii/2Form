namespace test.taskService;

public interface ITaskService
{
    internal int addTask(string name, string description, Status status, int catId);

    internal int removeTask(int id);
}