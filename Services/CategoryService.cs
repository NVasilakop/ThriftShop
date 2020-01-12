using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private ThriftShopContext dbContext;
        public CategoryService(ThriftShopContext context)
        {
            dbContext = context;
        }
        public List<Category> FindCategory(string category = null)
        {
            var categories = new List<Category>();
            if (!string.IsNullOrWhiteSpace(category))
            {
                categories = dbContext.Categories.Where(x => x.Description.Contains(category)).ToList();
            }
            else
            {
                categories = dbContext.Categories.ToList();
            }
            return categories;
        }
 
        public void AddCategory(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public void DeleteCategory(Guid categoryId)
        {
            var category = dbContext.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
           dbContext.Categories.Update(category);
            dbContext.SaveChanges();
        }
    }
}
