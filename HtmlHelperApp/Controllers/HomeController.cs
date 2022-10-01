using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HtmlHelperApp.Models;

namespace HtmlHelperApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public IActionResult Index(AllProcess allProcess)
    {
        var a = allProcess;
        return View(allProcess);
    }

    public IActionResult Index()
    {
        AllProcess allProcess = new AllProcess()
        {
            Id = 1,
            Name = "Tom",
            Enable = true,
            Password = "Par0l2003",
            Option = new List<string> { "Qora", "Oq", "Qizil", "Yashil" }
        };
        return View(allProcess);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string name, int age)
    {
        return Content($"{name} - {age}");
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
