using System.ComponentModel.DataAnnotations;

namespace test;

public class DpWithoutValue
{
    public DpWithoutValue(TypeDp type, string name)
    {
        Type = type;
        Name = name;
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Выберете тип дп")]
    public TypeDp Type { get; set; }
   
    [Required(ErrorMessage = "Введите имя")]
    [MinLength(3, ErrorMessage = "Имя должно быть больше 3 символов")]
    [MaxLength(20, ErrorMessage = "Имя должно быть меньше 20 символов")] 
    public string Name { get; set; }
    
    private List<int> _useCatId = null!;
    // Сделать value

    public void AddCatId(List<int> catsId)
    {
        foreach (var i in catsId)
        {
            if (_useCatId.Contains(i))
            {
                Console.WriteLine("Категория уже добавлена");
            }
            else
            {
                _useCatId.Add(i);
            }
        }
    }

    public List<int> UseCatId
    {
        get => _useCatId;
        set => _useCatId = value ?? throw new ArgumentNullException(nameof(value));
    }
}