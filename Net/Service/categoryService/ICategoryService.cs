using System.Collections;
using _Net.Models;

namespace _Net.Service.categoryService;

public interface ICategoryService
{
    internal Task AddCategory(Category category);

    internal Category getCategory(int id);

    internal IEnumerable<Category> GetAllCategories();

    internal void UpdateCategory(Category category);
    
    internal int RemoveCategory(int categoryId);
}