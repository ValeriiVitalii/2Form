using System.Diagnostics;
using _Net.Models;
using _Net.Models.Dp;
using _Net.Service.categoryService;
using _Net.Service.dpService;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using NetCore;
using NetCore.Models;

namespace _Net.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;

    private readonly ICategoryService _categoryService;
    
    private readonly IDpService _dpService;

    public CategoryController(ILogger<CategoryController> logger,
                                MyDbContext dbContext, 
                                ICategoryService categoryService,
                                IDpService dpService)
    {
        _logger = logger;
        _categoryService = new CategoryServiceDao(dbContext);
        _categoryService = categoryService;
        _dpService = dpService;
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
    public IActionResult CreateCategory(CreateCategoryAndDp categoryAndDp)
    {
        if (ModelState.IsValid)
        {
            // Адаптируем и сохраняем Category
            var category = categoryAndDp.Adapt<Category>();
            _categoryService.AddCategory(category); // После выполнения этого метода, у category должен быть установлен корректный Id
        
            // Адаптируем Dp и устанавливаем CategoryId
            var dp = categoryAndDp.Adapt<Dp>();
            dp.CategoryId = category.Id; // Устанавливаем CategoryId для Dp с корректным Id из только что сохраненной Category
            _dpService.AddDp(dp); // Сохраняем Dp
        
            return View("CategoryAndDpDetails", categoryAndDp);
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