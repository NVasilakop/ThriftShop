using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ThriftShop.Controllers
{
    public class ColorController : Controller
    {
        private IColorService colorService;
        public ColorController(IColorService _colorService)
        {
            colorService = _colorService;
            //colorService.AddColor(new Color {ColorId =Guid.NewGuid(), Code = "#FF0000", Description = "Red_HTMLColorCode" });
            //colorService.AddColor(new Color { ColorId = Guid.NewGuid(), Code = "#00FFFF", Description = "Cyan_HTMLColorCode" });
            //colorService.AddColor(new Color { ColorId = Guid.NewGuid(), Code = "#FF00FF", Description = "Magenta_HTMLColorCode" });
        }

        public ActionResult AddColor(Color color)
        {
            var colorSearched = colorService.GetColors(color.Code);
            if (colorSearched.Count == 0)
            {
                colorService.AddColor(new Color { ColorId = Guid.NewGuid(), Code = color.Code, Description = color.Description });
            }
            return View(color);
        }

        public ViewResult GetColors(string colorCode)
        {
            var colors = colorService.GetColors(colorCode);
            return View(colors);
        }
    }
}