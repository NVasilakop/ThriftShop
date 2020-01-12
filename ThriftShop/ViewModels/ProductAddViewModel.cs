using Interfaces;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftShop.ViewModels
{
    public class ProductAddViewModel 
    {
        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "Must write product description")]
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public List<Category> Categories { get; set; }
        public ICategoryService categoryService { get; set; }
        //private ProductAddViewModel(ICategoryService _service)
        //{
        //    categoryService = _service;
        //}
        //public ProductAddViewModel()
        //{
        //    Categories = categoryService.FindCategory();
        //}
    }
}
