using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Service.Interfaces
{
    public interface IItemService
    {
        public IList<IItem> ListAllItems();
        public IItem GetById (int id);
        public void AddImage (int itemId, Byte[] image, int itemColorId, int itemFabricId);
        public void RemoveImage(int idImage);
    }
}
