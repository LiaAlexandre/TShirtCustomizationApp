using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity.Factories
{
    public static class ImageFactory
    {
        public static Image CreateImageInstance(int itemId, int colorId, int fabricId, string image64)
        {
            return new Image(itemId, colorId, fabricId, image64);
        }
    }
}
