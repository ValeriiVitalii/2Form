using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using test.categoryService;

namespace NetCore.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;

    private readonly CategoryServiceDao _categoryService = new CategoryServiceDao();

    public CategoryController(ILogger<CategoryController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Home()
    {
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

    public IActionResult EditCategory()
    {
        //  var category = _categoryService.getCategory(id);

        return View(new Category("Имя", "Описание"));
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}