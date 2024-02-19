using System.ComponentModel.DataAnnotations;
using test;

namespace NetCore.Models;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите имя")]
    [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
    [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")]
    public String Name { get; set; }

    [Required(ErrorMessage = "Введите описание")]
    [MinLength(3, ErrorMessage = "Описание должно быть больше 3 символов")]
    [MaxLength(20, ErrorMessage = "Описание должно быть меньше 20 символов")]
    public String Description { get; set; }
  
    //  private Dictionary<Status, List<int>> _transitions = new Dictionary<Status, List<int>>(); //Ключ - статус, вэлью - id статусов доступных для перехода
   
    public List<DpWithoutValue> Dps = new List<DpWithoutValue>();
    
    public Category() { }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
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