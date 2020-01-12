using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void DeleteCategory(Guid categoryId);
        void UpdateCategory(Category category);
        List<Category> FindCategory(string category = null);
    }
}
