﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;
using System.Diagnostics;

namespace ShoppingAppClient.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            var urunler = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/products"))
                {
                    //Burada Newtonsoft.Json paketini yükledik.
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    urunler = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse);
                }
            }
            return View(urunler);
        }
        public async Task<IActionResult> GetProduct(int id)
        {
            var urun = new ProductViewModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:5200/api/products/{id}"))
                {
                    string stringResponse = await response.Content.ReadAsStringAsync();
                    urun = JsonConvert.DeserializeObject<ProductViewModel>(stringResponse);
                }

            }
            return View(urun);
        }
        public async Task<IActionResult> GetProducts20000()
        {
            var urunler = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/products"))
                {
                    //Burada Newtonsoft.Json paketini yükledik.
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    urunler = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse);
                }
            }
            urunler = urunler.Where(u => u.Price >= 20000).ToList();
            return View("Index",urunler);
        }
        public async Task<IActionResult> GetCategories()
        {
            var categories = new List<CategoryViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/Categories"))
                {
                    //Burada Newtonsoft.Json paketini yükledik.
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }
            }
            return View(categories);
        }
    }
}