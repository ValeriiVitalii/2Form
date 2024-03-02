using System.ComponentModel.DataAnnotations;

namespace _Net.Models;

public class Status
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Укажите имя")]
    public string Name { get; set; }

    public bool IsTerminal { get; set; }
    
    public List<Category> Categories { get; set; } = new List<Category>();
}