using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;

namespace NetCore.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;

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
            return View("CategoryDetails", category); 
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}