using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void DeleteProduct(Guid product);
        void UpdateProduct(Product product);
        List<Product> FindProductByName(string product);
        List<Product> FindProductByCategory(Guid categoryId);
    }
}
