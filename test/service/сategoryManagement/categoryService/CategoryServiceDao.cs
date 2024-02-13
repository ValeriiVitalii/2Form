namespace test.categoryService;

public class CategoryServiceDao : ICategoryService
{
    private Storage _storage = new Storage();
    
    public int addCategory(int categoryId, Category category)
    {
        _storage.addCategory(categoryId, category);
        return categoryId;
    }

    public int removeCategory(int categoryId)
    {
        _storage.removeCategory(categoryId);
        return categoryId;
    }
}