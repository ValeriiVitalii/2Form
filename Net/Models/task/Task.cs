using System.ComponentModel.DataAnnotations.Schema;

namespace _Net.Models.task;

public class Task
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    [Column(TypeName = "timestamp without time zone")] //Как-нибудь изменить на with time zone
    public DateTime DeadLine { get; set; }
    
    public int StatusId { get; set; }
    
    public Status Status { get; set; }
    
    public int CategoryId { get; set; }

    public Category Category { get; set; }
}