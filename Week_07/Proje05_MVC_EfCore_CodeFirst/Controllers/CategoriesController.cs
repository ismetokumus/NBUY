using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje05_MVC_EfCore_CodeFirst.Models;

namespace Proje05_MVC_EfCore_CodeFirst.Controllers
{
    
    public class CategoriesController : Controller
    {
       

        public IActionResult Index()
        {
            MyDbContext context= new MyDbContext();
            List<Category> categoris = context.Categories.ToList();
            return View(categoris);
        }

       
    }
}