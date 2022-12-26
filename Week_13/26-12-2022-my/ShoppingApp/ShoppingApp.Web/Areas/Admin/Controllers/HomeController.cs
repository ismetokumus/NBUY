using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    
    public class HomeController : Controller
    {
        private readonly IProductService _productManager;

        public HomeController(IProductService productManager)
        {
            _productManager = productManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SearchAdmin(string bul)
        {
            List<Product> searchResults = await _productManager.GetSearchResultsAsync(bul);
            List<ProductListDto> productDtos = new List<ProductListDto>();
            foreach (var product in searchResults)
            {
                productDtos.Add(new ProductListDto
                {
                    Product =product
                });
            }
            ViewBag.Title = "Ürün Arama Sonuçları";
            return View(productDtos);

        }
    }
   
}
