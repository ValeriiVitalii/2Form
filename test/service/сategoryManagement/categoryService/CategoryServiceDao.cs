namespace test.categoryService;

public class CategoryServiceDao : ICategoryService
{
    private Storage _storage = new Storage();
    
    public int addCategory(Category category)
    {
        return _storage.addCategory(category);
    }

    public int removeCategory(int categoryId)
    {
        _storage.removeCategory(categoryId);
        return categoryId;
    }
}