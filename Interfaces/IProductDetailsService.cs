using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IProductDetailsService
    {
        void AddProductDetails(ProductDetails productDetails);
        void DeleteProductDetails(Guid productDetailsGuid);
        void UpdateProductDetails(ProductDetails productDetails);
    }
}
