namespace _Net.Models.task;

public class TaskViewDto
{
    public string Name { get; set; }
    
    public DateTime DeadLine { get; set; }
    
    public int StatusId { get; set; }
    
    public int CategoryId { get; set; }
}