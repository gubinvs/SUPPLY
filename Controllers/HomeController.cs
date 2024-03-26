using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SUPPLY.Models;
using System.IO;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace SUPPLY.Controllers;

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

    public IActionResult Specification()
    { 
        return View();
    }

    [HttpPost]
    public IActionResult Formfile(IFormFile uploadedFile)
    {

        // IFormFileCollection files = request.Form.Files;
        // путь к папке Files
        string path = "/Users/vladimirgubin/web-developer/SUPPLY/wwwroot/file/";
        //string path = $"{Directory.GetCurrentDirectory()}/wwwroot/file"; // Directory.GetCurrentDirectory() метод определяет текущую директорию
        // сохраняем файл в папку Files в каталоге wwwroot
        using (FileStream fileStream = new FileStream(path, FileMode.Create))
        {
            
        }

        return View("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}




