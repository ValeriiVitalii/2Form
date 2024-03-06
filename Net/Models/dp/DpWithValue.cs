

using _Net.Models.Dp;
using Task = _Net.Models.task.Task;

public class DpWithValue
{
    public int Id { get; set; }
    
    public TypeDp Type { get; set; }
    
    public string Name { get; set; }
    
    public byte[] Value { get; set; }

    public int TaskId { get; set; }
    
    public Task Task { get; set; }

    public bool Fill { get; set; }
}