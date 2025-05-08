using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleDotNetCoreWithBootstrap.Models;

namespace SampleDotNetCoreWithBootstrap.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

        public IActionResult Index() 
    {
        Inventory inventory = new Inventory (
        01, 
        "ADIDAS", 
        "SHOES", 
        0001, 
        10, 
        "4-3-21"
        );

        return View(inventory);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
