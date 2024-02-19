using NetCore.Models;

namespace test.categoryService;

public class CategoryServiceDao : ICategoryService
{
    private Storage _storage = new Storage();
    
    public int AddCategory(Category category)
    {
        category.Dps = new List<DpWithoutValue> { new DpWithoutValue(TypeDp.Text, "Текст") };
        
        DpWithoutValue dpWithoutValue = new DpWithoutValue(TypeDp.Text, "Текст");
        return _storage.AddCategory(category);
    }

    public Category getCategory(int id)
    {
        return _storage.getCategory(id);
    }

    public int RemoveCategory(int categoryId)
    {
        _storage.RemoveCategory(categoryId);
        return categoryId;
    }
}