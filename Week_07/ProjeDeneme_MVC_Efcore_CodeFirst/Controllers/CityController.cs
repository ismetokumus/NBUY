using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjeDeneme_MVC_Efcore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjeDeneme_MVC_Efcore_CodeFirst.Controllers
{
    [Route("[controller]")]
    public class CityController : Controller
    {

        public IActionResult Index()
        {
            MyDbContext context = new MyDbContext();
            List<City> city = context
                .City
                .Include(c => c.Product)
                .ToList();
            return View(city);
        }

    }
}