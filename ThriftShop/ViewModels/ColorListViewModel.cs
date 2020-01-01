using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriftShop.ViewModels
{
    public class ColorListViewModel
    {
        public List<Color> Colors { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString{ get; set; }

    }
}
