using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using test.service.сategoryManagement.dpService;

namespace NetCore.Controllers;

public class DpController : Controller
{
    private readonly ILogger<DpController> _logger;

    private readonly DpWithoutValueServiceDao _dpWithoutValueService;

    public DpController(ILogger<DpController> logger, MyDbContext dbContext)
    {
        _logger = logger;
        _dpWithoutValueService = new DpWithoutValueServiceDao(dbContext);
    }

    public IActionResult Home()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}