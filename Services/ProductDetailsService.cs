using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProductDetailsService : IProductDetailsService
    {
        public ThriftShopContext dbContext { get; set; }
        public ProductDetailsService(ThriftShopContext _context)
        {
            dbContext = _context;
        }

        public void AddProductDetails(ProductDetails productDetails)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductDetails(Guid productDetailsGuid)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductDetails(ProductDetails productDetails)
        {
            throw new NotImplementedException();
        }
    }
}
