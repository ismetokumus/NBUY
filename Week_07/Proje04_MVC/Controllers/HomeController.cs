﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje04_MVC.Controllers;

public class Product{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Category{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        string ad="İsmet";
        ViewBag.KisiAd=ad;
        string dil="En";
        string selamlama;
        if (dil == "Tr")
        {
            selamlama="Hoş geldiniz";

        }else if(dil == "En")
        {
            selamlama = "Welcome";
        }
        else
        {
            selamlama = "";
        }
        ViewBag.Selam=selamlama;
        return View();
    }
    public IActionResult About()
    {
        ViewBag.Hata=false;
        ViewData["Not"] = 75;

        List<string> adlar = new List<string>(){"Sema","Harun","Sefa","İsmet"};
        ViewData["Adlar"]=adlar;

        List<string> bolumler = new List<string>(){"İnsan Kaynakları","Muhasebe","Eğitim","Satış"};
        ViewBag.Bolumler = bolumler;

        return View();
    }

    public IActionResult GetProducts()
    {
        List<Product> products = new List<Product>(){
            new Product(){Id=1, Name="Iphone 13", Price=24000},
            new Product(){Id=2, Name="Iphone 14", Price=34000},
            new Product(){Id=3, Name="Iphone 15", Price=44000},
            new Product(){Id=4, Name="Iphone 16", Price=54000},
            new Product(){Id=5, Name="Iphone 17", Price=64000}
        };
        // ViewBag.Products = products;
        return View(products) ;
    }
    public IActionResult GetCategory(){
        List<Category> categories = new List<Category>(){
            new Category(){Id=1, Name="Phone"},
            new Category(){Id=2, Name="Computer"},
            new Category(){Id=2, Name="Electronic"}
        };
        return View(categories);
    }

}
