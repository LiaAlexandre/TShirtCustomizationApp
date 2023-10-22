using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Service.DTOs.Interfaces;

namespace TShirtCustomizationApp.Service.Interfaces
{
    public interface IItemService
    {
        public IList<IItemListDTO> ListAllItems();
        public IItemDetailDTO GetById (int id);
        public void AddImage (int itemId, int colorId, int fabricId, string image64);
        public void RemoveImage(int idImage);
    }
}
