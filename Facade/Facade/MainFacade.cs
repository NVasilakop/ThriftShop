using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public abstract class MainFacade
    {
        public IProductService productService { get; set; }
        public IProductDetailsService productDetailsService{ get; set; }
        public ICategoryService categoryService { get; set; }
        public IColorService colorService { get; set; }

        public MainFacade(IProductService _productService, IProductDetailsService _productDetailsService, ICategoryService _categoryService, IColorService _colorService)
        {
            productDetailsService = _productDetailsService;
            productService = _productService;
            categoryService = _categoryService;
            colorService = _colorService;
        }
    }
}
