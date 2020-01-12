using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ProductService : IProductService
    {
        public ThriftShopContext dbContext { get; set; }
        public ProductService(ThriftShopContext _context)
        {
            dbContext = _context;
        }
        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void DeleteProduct(Guid product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> FindProductByName(string product)
        {
            var products = new List<Product>();
            if (!string.IsNullOrWhiteSpace(product))
            {
                products = dbContext.Products.Where(x => x.Description.Contains(product)).ToList();
            }
            else
            {
                products = dbContext.Products.ToList();
            }
            return products;

        }

        public List<Product> FindProductByCategory(Guid categoryId)
        {
            return dbContext.Products.Where(x => x.CategoryId == categoryId).ToList();
        }
    }
}
