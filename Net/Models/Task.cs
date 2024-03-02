using _Net.Models;

namespace NetCore.Models;

public class Task
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTime DeadLine { get; set; }
    
    public int StatusId { get; set; }
    
    public Status Status { get; set; }
    
    public int CategoryId { get; set; }

    public Category Category { get; set; }
}