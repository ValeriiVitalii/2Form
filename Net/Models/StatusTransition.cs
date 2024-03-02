using _Net.Models;

public class StatusTransition
{
    public StatusTransition()
    {
    }

    public StatusTransition(int statusId, int allowedStatusId, int categoryId)
    {
        StatusId = statusId;
        AllowedStatusId = allowedStatusId;
        CategoryId = categoryId;
    }

    public int Id { get; set; }
    
    public int StatusId { get; set; }
    
    public Status Status { get; set; }
    
    public int AllowedStatusId { get; set; }
    
    public Status AllowedStatus { get; set; }
    
    public int CategoryId { get; set; }
    
    public Category Category { get; set; }
}