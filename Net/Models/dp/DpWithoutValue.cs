using System.ComponentModel.DataAnnotations;

namespace _Net.Models.Dp
{
    public class DpWithoutValue
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Выберете тип дп")]
        public TypeDp Type { get; set; }
       
        [Required(ErrorMessage = "Введите имя")]
        [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
        [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")] 
        public string Name { get; set; }
        
        // Ссылка на Category
        public int CategoryId { get; set; } // FK
        public Category Category { get; set; } // Навигационное свойство
    }
}