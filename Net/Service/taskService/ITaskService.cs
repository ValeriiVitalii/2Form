using Task = _Net.Models.task.Task;

namespace _Net.Service.taskService;
using Task = Task;


public interface ITaskService
{
    internal void AddTask(Task task);
    internal Task GetTask(int id);
    internal Task<IEnumerable<Task>> GetAllTasksFromCategory(int catId);
}