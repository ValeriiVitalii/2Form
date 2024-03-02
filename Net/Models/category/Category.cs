using System.ComponentModel.DataAnnotations;

namespace _Net.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
        [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите описание")]
        [MinLength(3, ErrorMessage = "Описание должно быть больше 3 символов")]
        [MaxLength(20, ErrorMessage = "Описание должно быть меньше 20 символов")]
        public string Description { get; set; }
        
        public List<Status> Statuses { get; set; } = new List<Status>();
    }
}