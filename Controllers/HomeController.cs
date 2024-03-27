using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SUPPLY.Models;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

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
    public async Task<IActionResult> AddFileServer(IFormFile uploadedFile)
    {
        // if (uploadedFile != null)
        // {
            // путь к папке Files
            string path = $"{Directory.GetCurrentDirectory()}/wwwroot/file/" + uploadedFile.FileName; // Directory.GetCurrentDirectory() метод определяет текущую директорию
            // сохраняем файл в папку Files в каталоге wwwroot
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }
        // }

        return RedirectToAction("Specification");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}




