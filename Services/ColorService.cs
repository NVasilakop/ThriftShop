using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ColorService : IColorService
    {
        private ThriftShopContext dbContext ;
        public ColorService(ThriftShopContext context)
        {
            dbContext = context;
        }

        public void AddColor(Color color)
        {
            dbContext.Colors.Add(color);
            dbContext.SaveChanges();
        }

        public List<Color> GetColors(string colorCode = null)
        {
            var colors = new List<Color>();
            if (!string.IsNullOrWhiteSpace(colorCode))
            {
                 colors = dbContext.Colors.Where(x => x.Code.Contains(colorCode)).ToList();
                return colors;
            }
            else
            {
                colors = dbContext.Colors.ToList();
                return colors;
            }
        }
    }
}
