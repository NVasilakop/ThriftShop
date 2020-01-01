using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IColorService
    {
        void AddColor(Color color);
        List<Color> GetColors(string colorCode=null);
    }
}
