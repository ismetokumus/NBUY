using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.API.Model;
using ShoppingApi.Business.Abstract;

namespace ShoppingApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            List<CategoriDto> categoriDtos= new List<CategoriDto>();
            foreach (var category in categories)
            {
                categoriDtos.Add(new CategoriDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,
                    Url = category.Url
                });

            }
            return Ok(categoriDtos);
        }
    }
}
