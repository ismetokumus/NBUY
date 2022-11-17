using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace ProjeDeneme_MVC_Efcore_CodeFirst.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

}
