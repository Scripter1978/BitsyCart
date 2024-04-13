using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.UI.Models;

namespace MVC.UI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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


    [Route("{id?}", Name = null, Order = 1)] 
    public IActionResult Public()
    {
        
        return View( new  List<ProductItem>()
        {
            new ProductItem{ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
            new ProductItem{ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
            new ProductItem{ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
            new ProductItem{ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
            new ProductItem{ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
            new ProductItem{ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
            new ProductItem{ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
            new ProductItem{ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
            new ProductItem{ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
            new ProductItem{ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
            new ProductItem{ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
            new ProductItem{ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
            new ProductItem{ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
            new ProductItem{ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
            new ProductItem{ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
            new ProductItem{ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"}
        });
    } 
        
        
}