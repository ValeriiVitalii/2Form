using System.Diagnostics;
using _Net.Models.Dp;
using _Net.Service.dpService;
using Microsoft.AspNetCore.Mvc;
using NetCore;
using NetCore.Models;

namespace _Net.Controllers;

public class DpController : Controller
{
    private readonly ILogger<DpController> _logger;

    private readonly IDpService _dpService;

    public DpController(ILogger<DpController> logger, MyDbContext dbContext, IDpService dpService)
    {
        _logger = logger;
        _dpService = new DpServiceDao(dbContext);
        _dpService = dpService;
    }

    public IActionResult Home()
    {
        // Получение списка категорий из базы данных (замените этот код на вашу логику получения категорий)
        var dps = _dpService.GetAllDp();

        // Передача списка категорий в ViewBag
        ViewBag.Dps = dps;
        
        return View();
    }
    
    [HttpGet]
    public IActionResult CreateDpWithoutValue() => View();
    
    [HttpPost]
    public IActionResult CreateDpWithoutValue(Dp dp)
    {
        if (ModelState.IsValid)
        {
            _dpService.AddDp(dp);
            return View("DpDetails", dp); 
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}