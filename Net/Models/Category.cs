using System.ComponentModel.DataAnnotations;
using test;

namespace NetCore.Models
{
    public class Category
    {
        public Category()
        {
            Dps = new List<DpWithoutValue>();
        }

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
        [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите описание")]
        [MinLength(3, ErrorMessage = "Описание должно быть больше 3 символов")]
        [MaxLength(20, ErrorMessage = "Описание должно быть меньше 20 символов")]
        public string Description { get; set; }

        public List<DpWithoutValue> Dps { get; set; } // Навигационное свойство для связи с DpWithoutValue
    }
    /*public void addStatus(Status status, List<int> ids)
    {
        _transitions.Add(status, ids);  //Не сделал в дефолтном сеттере ибо тогда нужно будет подавать в метод мапу         
    }*/
    
    /*public void addTransitions(Status status, List<int> ids)
    {
        foreach (var id in ids)
        {
            _transitions[status].Add(id);
        }
    }*/
}