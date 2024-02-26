using NetCore;
using NetCore.Models;

namespace test.categoryService;

public class CategoryServiceDao : ICategoryService
{
    private Storage _storage = new Storage();
    private readonly MyDbContext _db;
    
    public CategoryServiceDao(MyDbContext dbContext)
    {
        _db = dbContext;
    }
    
    public int AddCategory(Category category)
    {
        // category.Dps = new List<DpWithoutValue> { new DpWithoutValue(TypeDp.Text, "Текст") };

        _db.Categories.Add(category);
        _db.SaveChanges();
        return _storage.AddCategory(category);
    }

    public Category getCategory(int id)
    {
        return _db.Categories.Find(id);
    }
    
    public List<Category> GetAllCategories()
    {
        return _db.Categories.ToList();
    }
    
    public void UpdateCategory(Category category)
    {
        _db.Categories.Update(category); 
        _db.SaveChanges();
    }

    public int RemoveCategory(int categoryId)
    {
        _storage.RemoveCategory(categoryId);
        return categoryId;
    }
}