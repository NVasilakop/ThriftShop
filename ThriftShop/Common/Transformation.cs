using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThriftShop.ViewModels;

namespace ThriftShop.Common
{
    public static class Transformation
    {
        public static Product ToProduct(this ProductAddViewModel model)
        {
            return new Product
            {
                Category = model.Categories.FirstOrDefault(),
                CategoryId = model.CategoryId,
                Description = model.Description,
                ProductId = Guid.NewGuid()
            };
        }
    }
}
