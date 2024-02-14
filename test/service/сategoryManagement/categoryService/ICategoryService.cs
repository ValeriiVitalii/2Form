namespace test.categoryService;

public interface ICategoryService
{
    internal int addCategory(Category category);
    
    internal int removeCategory(int categoryId);
}