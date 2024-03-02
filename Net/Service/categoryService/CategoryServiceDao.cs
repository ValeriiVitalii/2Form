using _Net.Models;
using _Net.Service.statusService;
using NetCore;

namespace _Net.Service.categoryService;

public class CategoryServiceDao : ICategoryService
{
    private readonly MyDbContext _db;

    private readonly IStatusService _statusService;
    private readonly IStatusTransitionService _statusTransitionService;
    
    public CategoryServiceDao(MyDbContext dbContext,
                                IStatusService statusService,
                                IStatusTransitionService statusTransitionService)
    {
        _db = dbContext;
        _statusService = statusService;
        _statusTransitionService = statusTransitionService;
    }
    
    public async Task AddCategory(Category category)
    {
        category.Statuses = await _statusService.GetDefaultStatuses(); //Добавляем базовые статусы
        
        _db.Categories.Add(category);
        await _db.SaveChangesAsync();
        
        await _statusTransitionService.AddDefaultTransition(category.Id); //Добавляем базовые переходы
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
        return categoryId;
    }
}