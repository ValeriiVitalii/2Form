using System.ComponentModel.DataAnnotations;
using _Net.Models.Dp;

namespace _Net.Models;

public class CreateCategoryAndDp
{
    [Required(ErrorMessage = "Введите имя")]
    [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
    [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")]
    public string CategoryName { get; set; }

    [Required(ErrorMessage = "Введите описание")]
    [MinLength(3, ErrorMessage = "Описание должно быть больше 3 символов")]
    [MaxLength(20, ErrorMessage = "Описание должно быть меньше 20 символов")]
    public string CategoryDescription { get; set; }
    
    [Required(ErrorMessage = "Выберете тип дп")]
    public TypeDp DpType { get; set; }
       
    [Required(ErrorMessage = "Введите имя")]
    [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
    [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")] 
    public string DpName { get; set; }
}