using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampledotNetWebApp.Models;

namespace SampledotNetWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Name fullName = new Name(){
            FirstName = "Mico",
            MiddleInitial = "L",
            LastName = "Galindez",
            Age = 23
        };
        return View(fullName);
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
