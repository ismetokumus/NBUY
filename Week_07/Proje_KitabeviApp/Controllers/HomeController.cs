﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje_KitabeviApp.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

}
