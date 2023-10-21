using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;
using TShirtCustomizationApp.Service.Interfaces;

namespace TShirtCustomizationApp.Service
{
    public class ItemService : IItemService
    {
        private IRepository<IItem> _itemRepository;
        private IRepository<IColor> _colorRepository;

        public ItemService(IRepository<IItem> itemRepository, IRepository<IColor> colorRepository)
        {
            _itemRepository = itemRepository;
            _colorRepository = colorRepository;
        }
        public void AddImage(int itemId, byte[] image, int itemColorId, int itemFabricId)
        {
            throw new NotImplementedException();
        }

        public IItem GetById(int id)
        {
            return _itemRepository.GetById(id);
        }

        public IList<IItem> ListAllItems()
        {
            return _itemRepository.ListAll();
        }

        public void RemoveImage(int idImage)
        {
            throw new NotImplementedException();
        }
    }
}
