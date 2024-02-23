using NetCore.Models;

namespace test.categoryService;

public interface ICategoryService
{
    internal int AddCategory(Category category);

    public Category getCategory(int id);

    public List<Category> GetAllCategories();

    public void UpdateCategory(Category category);
    
    internal int RemoveCategory(int categoryId);
}