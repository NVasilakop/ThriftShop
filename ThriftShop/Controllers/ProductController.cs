using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThriftShop.Common;
using ThriftShop.ViewModels;

namespace ThriftShop.Controllers
{
    public class ProductController : Controller
    {
        public IProductFacade productFacade { get; set; }
        public ICategoryService categoryService { get; set; }
        public ProductController(IProductFacade _facade,ICategoryService _service)
        {
            productFacade = _facade;
            categoryService = _service;
        }
        public ActionResult AddProduct(ProductAddViewModel productModel)
        {
            var descriptions = new List<string>();
            categoryService.FindCategory().ForEach(x => descriptions.Add(x.Description));
            ViewData["Categories"] = new SelectList(descriptions); 
            if(!string.IsNullOrWhiteSpace(productModel.Description))
            productFacade.AddProduct(productModel.ToProduct());
            return View(productModel);
        }
    }
}