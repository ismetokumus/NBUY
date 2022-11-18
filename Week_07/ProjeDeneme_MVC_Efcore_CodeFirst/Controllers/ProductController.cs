using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ProjeDeneme_MVC_Efcore_CodeFirst.Models;

namespace ProjeDeneme_MVC_Efcore_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            MyDbContext context = new MyDbContext();
            List<Product> products = context
                .Product
                
                .ToList();
            
            return View(products);
        }
    }
}