using Microsoft.EntityFrameworkCore;
using NetCore;
using Task = _Net.Models.task.Task;

namespace _Net.Service.taskService;

public class TaskServiceDao : ITaskService
{
    
    private readonly MyDbContext _db;
    
    public TaskServiceDao(MyDbContext db)
    {
        _db = db;
    }

    public void AddTask(Task task)
    {
        task.StatusId = 1;
        _db.Add(task);
        _db.SaveChanges();
    }

    public Task GetTask(int taskId)
    {
        return _db.Find<Task>(taskId);
    }
    
    public async Task<IEnumerable<Task>> GetAllTasksFromCategory(int catId)
    {
        return await _db.Tasks
            .Where(c => c.CategoryId == catId)
            .Include(t => t.Status) // Включаем данные о статусе
            .ToListAsync();
    }
}