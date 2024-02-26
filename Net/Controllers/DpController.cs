using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using test;
using test.dpService;
using test.service.сategoryManagement.dpService;

namespace NetCore.Controllers;

public class DpController : Controller
{
    private readonly ILogger<DpController> _logger;

    private readonly IDpWithoutValueService _dpWithoutValueService;

    public DpController(ILogger<DpController> logger, MyDbContext dbContext, IDpWithoutValueService dpWithoutValueService)
    {
        _logger = logger;
        _dpWithoutValueService = new DpWithoutValueServiceDao(dbContext);
        _dpWithoutValueService = dpWithoutValueService;
    }

    public IActionResult Home()
    {
        // Получение списка категорий из базы данных (замените этот код на вашу логику получения категорий)
        var dps = _dpWithoutValueService.GetAllDpWithoutValue();

        // Передача списка категорий в ViewBag
        ViewBag.Dps = dps;
        
        return View();
    }
    
    [HttpGet]
    public IActionResult CreateDpWithoutValue() => View();
    
    [HttpPost]
    public IActionResult CreateDpWithoutValue(DpWithoutValue dpWithoutValue)
    {
        if (ModelState.IsValid)
        {
            _dpWithoutValueService.addDpWithoutValue(dpWithoutValue);
            return View("DpDetails", dpWithoutValue); 
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}