using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftShop.Controllers
{
    public class CategoryController : Controller
    {
        public ICategoryService categoryService { get; set; }
        public CategoryController(ICategoryService _service)
        {
            categoryService = _service;
        }
        public ActionResult AddCategory(Category category)
        {
            var colorSearched = categoryService.FindCategory(category.Description);
            if (colorSearched.Count == 0)
            {
                categoryService.AddCategory(new Category {CategoryId = Guid.NewGuid(),Description = category.Description });
            }
            return View(category);
        }
    }
}
