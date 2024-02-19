using NetCore.Models;

namespace test.categoryService;

public interface ICategoryService
{
    internal int AddCategory(Category category);

    public Category getCategory(int id);
    
    internal int RemoveCategory(int categoryId);
}