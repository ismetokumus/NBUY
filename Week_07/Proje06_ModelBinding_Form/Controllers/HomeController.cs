using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_ModelBinding_Form.Models;

namespace Proje06_ModelBinding_Form.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    // Tip belli değilse http get tir
    public IActionResult YasGrubu()
    {
        return View();
    }
    [HttpPost]
    public IActionResult YasGrubu(int yas, string ad)
    {
        if (yas==0)
        {
            ViewBag.YasGrubu="Lütfen bir yaş bilgisi giriniz!";
        }
        else if(yas<18)
        {
            ViewBag.YasGrubu=$"{ad}, Reşit değilsiniz";
        }else if(yas<40)
        {
            ViewBag.YasGrubu=$"{ad}, Gençsiniz";

        }else if (yas<60)
        {
            ViewBag.YasGrubu=$"{ad}, Gençlere Taş Çıkartırsınız";
        }else
        {
            ViewBag.YasGrubu=$"{ad}, Emekli";
        }
        return View();
    }

    public IActionResult CreateProduct()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateProduct(Product product, bool IsApproved)
    {
        //Burada veri tabanına kayıt işlemi vb. yapılacak.
        //Şimdilik 
        // ViewBag.ResultHeader=$"{productName} adlı ürün eklendi."; 
        // ViewBag.ResultBody=$"Category: {productCategory} Price: {productPrice} "; 
        return View(product);
    }



















    // public IActionResult VerileriAl(string txtAd, int txtYas)
    // {
    //     return View();
    // }

}
