using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using test.categoryService;

namespace NetCore.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;

    private readonly CategoryServiceDao _categoryService;

    public CategoryController(ILogger<CategoryController> logger, MyDbContext dbContext)
    {
        _logger = logger;
        _categoryService = new CategoryServiceDao(dbContext);
    }

    
    public IActionResult Home()
    {
        // Получение списка категорий из базы данных (замените этот код на вашу логику получения категорий)
        var categories = _categoryService.GetAllCategories();

        // Передача списка категорий в ViewBag
        ViewBag.Categories = categories;
        
        return View();
    }

    [HttpGet]
    public IActionResult CreateCategory() => View();
    
    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        if (ModelState.IsValid)
        {
            _categoryService.AddCategory(category);
            return View("CategoryDetails", category); 
        }
        return View();
    }
    
    /*[HttpGet]
    public IActionResult GetCategory() => View();*/
    
    [HttpGet]
    public IActionResult GetCategoryForId([FromQuery] int id)
    {
        Console.WriteLine(id);
        var category = _categoryService.getCategory(id);
        return View("GetCategoryForId", category);
    }
    
    /*[HttpGet]
    public IActionResult GetCategory()
    {

        var id = _categoryService.AddCategory(new Category("Name", "Описание") );
        return View("GetCategoryForId" ,_categoryService.getCategory(id));
    }
    */
    
    [HttpPost]
    public IActionResult EditCategory(int id, Category category)
    {
        if (ModelState.IsValid)
        {
            var existingCategory = _categoryService.getCategory(id);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
                _categoryService.UpdateCategory(existingCategory);
                return View("CategoryDetails", category); 
            }
        }
        // Если данные не сохранены, вернуть форму с ошибками
        return View(category);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}