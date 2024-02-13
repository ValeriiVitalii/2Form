namespace test.categoryService;

public interface ICategoryService
{
    internal int addCategory(int categoryId, Category category);
    
    internal int removeCategory(int categoryId);
}