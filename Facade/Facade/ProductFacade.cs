using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class ProductFacade : MainFacade , IProductFacade
    {
        public IProductService productService { get; set; }
        public IProductDetailsService productDetailsService { get; set; }
        public ProductFacade(IProductService service, IProductDetailsService proddetailsService) : base(service,proddetailsService,null,null)
        {
            productDetailsService = productDetailsService;
            productService = service;
        }

        public void AddProduct(Product product)
        {
           var specificItem =  productService.FindProductByName(product.Description).FirstOrDefault(x => x.CategoryId == product.CategoryId);
           if(specificItem == null)
            {
                productService.AddProduct(product);
            }
            else
            {
                throw new Exception("");
            }
        }
    }
}
