using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;

namespace ShoppingAppClient.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
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
            ViewBag.Den=categories;
            return View();
        }
    }
}
