using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;
using TShirtCustomizationApp.Service.DTOs;
using TShirtCustomizationApp.Service.DTOs.Interfaces;
using TShirtCustomizationApp.Service.Interfaces;

namespace TShirtCustomizationApp.Service
{
    public class ItemService : IItemService
    {
        private IRepository<IItem> _itemRepository;
        private IItemColorRepository<IItemColor> _itemColorRepository;
        private IItemFabricRepository<IItemFabric> _itemFabricRepository;
        private IImageRepository<IImage> _imageRepository;

        public ItemService(IRepository<IItem> itemRepository, IItemColorRepository<IItemColor> itemColorRepository,
            IItemFabricRepository<IItemFabric> itemFabricRepository, IImageRepository<IImage> imageRepository)
        {
            _itemRepository = itemRepository;
            _itemColorRepository = itemColorRepository;
            _itemFabricRepository = itemFabricRepository;
            _imageRepository = imageRepository;
        }
        public void AddImage(int itemId, byte[] image, int itemColorId, int itemFabricId)
        {
            throw new NotImplementedException();
        }

        public IItem GetById(int id)
        {
            return _itemRepository.GetById(id);
        }

        public IList<IItemListDTO> ListAllItems()
        {
            IList<IItemListDTO> itemsList = new List<IItemListDTO>();

            IList<IItem> items = _itemRepository.ListAll();

            foreach (IItem item in items)
            {
                IItemListDTO itemList = new ItemListDTO();

                itemList.ItemId = item.Id;
                itemList.ItemName = item.Name;
                itemList.ColorsCount = _itemColorRepository.GetByItemId(item.Id).Count;
                itemList.FabricsCount = _itemFabricRepository.GetByItemId(item.Id).Count;
                itemList.ImagesCount = _imageRepository.GetByItemId(item.Id).Count;

                itemsList.Add(itemList);
            }

            return itemsList;
        }

        public void RemoveImage(int idImage)
        {
            throw new NotImplementedException();
        }
    }
}
