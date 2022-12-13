using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Sevices;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmailService _emailService;

        public HomeController(EmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            _emailService.Send("mesut@wissen.com", "Test mesaı", "Konu");
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
    }
}