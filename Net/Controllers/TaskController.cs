using System.Diagnostics;
using _Net.Models.task;
using _Net.Service.statusService;
using _Net.Service.taskService;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NetCore.Models;
using Task = _Net.Models.task.Task;

namespace _Net.Controllers;

public class TaskController : Controller
{
    private readonly ILogger<CategoryController> _logger;
    
    private readonly IStatusService _statusService;

    private readonly ITaskService _taskService;
    
    public TaskController(ILogger<CategoryController> logger,
        ITaskService taskService,
        IStatusService statusService)
    {
        _logger = logger;
        _taskService = taskService;
        _statusService = statusService;
    }

    [HttpGet]
    public IActionResult CreateTask(int categoryId)
    {
        Console.WriteLine($"{categoryId}////////////////// get");
        TaskViewDto taskViewDto = new TaskViewDto{CategoryId = categoryId, StatusId = 1}; //Статус - Новая
        return View(taskViewDto);
    }
    
    [HttpPost]
    public IActionResult CreateTask(TaskViewDto taskViewDto)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine($"{taskViewDto.CategoryId}////////////////// post");
            Console.WriteLine($"{taskViewDto.StatusId}////////////////// status post");

            var task = taskViewDto.Adapt<Task>();
            _taskService.AddTask(task);
            return View("TaskDetails", task); //изменить на GetAllTasksFromCategory
        }
        return View();
    } 

    public async Task<IActionResult> GetAllTasksFromCategory(int id)
    {
        IEnumerable<Task> tasks = await _taskService.GetAllTasksFromCategory(id);
        ViewBag.CategoryId = id;

         return View(tasks);
    }
    
    
    /*public IActionResult Home()
    {
        // Получение списка категорий из базы данных 
        var categories = _categoryService.GetAllCategories();

        // Передача списка категорий в ViewBag
        ViewBag.Categories = categories;
        
        return View();
    }*/
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}