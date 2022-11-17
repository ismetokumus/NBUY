using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje_KitabeviApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje_KitabeviApp.Controllers
{
    
    public class KitabeviController : Controller
    {
        

        public IActionResult Kategori( )
        {
            MyDbKitabevi myDbKitabevi = new MyDbKitabevi();
            List<Kategori> kategoriler = myDbKitabevi
                .Kategoriler
                .ToList();
            return View(kategoriler);
        }
        public IActionResult Kitaplar( )
        {
            MyDbKitabevi myDbKitabevi = new MyDbKitabevi();
            List<Kitap> kitaplar = myDbKitabevi
                .Kitaplar
                .Include(k => k.Kategori )
                .Include(y=> y.Yazar)
                .ToList();
            return View(kitaplar);
        }
        public IActionResult Yazarlar( )
        {
            MyDbKitabevi myDbKitabevi = new MyDbKitabevi();
            List<Yazar> yazarlar = myDbKitabevi
                .Yazarlar
                .ToList();
            return View(yazarlar);
        }
        

        
    }
}