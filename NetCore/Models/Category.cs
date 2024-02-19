using System.ComponentModel.DataAnnotations;

namespace NetCore.Models;

public class Category
{
    [Required(ErrorMessage = "Введите имя")]
    [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
    [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")]
    public String name { get; set; }
}