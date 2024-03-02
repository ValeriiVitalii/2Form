using System.ComponentModel.DataAnnotations;

namespace _Net.Models.Dp
{
    public class Dp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Выберете тип дп")]
        public TypeDp Type { get; set; }
       
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }
        
        // Ссылка на Category
        public int CategoryId { get; set; } // FK
        public Category Category { get; set; } // Навигационное свойство
    }
}