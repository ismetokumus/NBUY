﻿using BlogApp.Entities.Dtos;
using BlogApp.Mvc.Areas.Admin.Models;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Extensions;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using BlogApp.Shared.Utilities.Result.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlogApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;

        public CategoryController(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            var result=await _categoryService.GetAllByNonDeleted();
            if (result.ResultStatus==ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        public IActionResult Add()
        {
            return PartialView("_CategoryAddPartial");
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.Add(categoryAddDto,"İsmet Okumuş");
                if (result.ResultStatus==ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto = result.Data,
                        CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial",categoryAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
            {
                CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial", categoryAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
    
        public async Task<JsonResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllByNonDeleted();
            var resultJson = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(resultJson);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int categoryId)
        {
            var result = await _categoryService.Delete(categoryId, "İsmet Okumuş");
            var resultJson = JsonSerializer.Serialize(result);
            return Json(resultJson);
        }
    }
}
