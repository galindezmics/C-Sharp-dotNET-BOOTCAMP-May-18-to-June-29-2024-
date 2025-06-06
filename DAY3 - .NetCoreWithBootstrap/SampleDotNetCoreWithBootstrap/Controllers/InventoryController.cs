using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleDotNetCoreWithBootstrap.Models;

namespace SampleDotNetCoreWithBootstrap.Controllers;

public class InventoryController : Controller
{
    private readonly ILogger<InventoryController> _logger;

    public InventoryController(ILogger<InventoryController> logger)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
