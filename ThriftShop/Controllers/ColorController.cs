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
        public ViewResult AddColor()
        {
            //colorService.AddColor(new Color {ColorId =Guid.NewGuid(), Code = "1231", Description = "whatever" });
            return View();
        }

        public ViewResult GetColors(string colorCode)
        {
            var colors = colorService.GetColors(colorCode);
            return View(colors);
        }
    }
}