using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Factories;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;
using TShirtCustomizationApp.Service.DTOs;
using TShirtCustomizationApp.Service.DTOs.Interfaces;
using TShirtCustomizationApp.Service.Interfaces;

namespace TShirtCustomizationApp.Service
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;
        private IItemColorRepository _itemColorRepository;
        private IItemFabricRepository _itemFabricRepository;
        private IImageRepository _imageRepository;
        private IColorRepository _colorRepository;
        private IFabricRepository _fabricRepository;

        public ItemService(IItemRepository itemRepository,
            IItemColorRepository itemColorRepository,
            IItemFabricRepository itemFabricRepository,
            IImageRepository imageRepository,
            IColorRepository colorRepository,
            IFabricRepository fabricRepository)
        {
            _itemRepository = itemRepository;
            _itemColorRepository = itemColorRepository;
            _itemFabricRepository = itemFabricRepository;
            _imageRepository = imageRepository;
            _colorRepository = colorRepository;
            _fabricRepository = fabricRepository;
        }
        public void AddImage(int itemId, int colorId, int fabricId, string image64)
        {
            try
            {
                _imageRepository.Save(
                        ImageFactory.CreateImageInstance(itemId, colorId, fabricId, image64)
                    );

                _imageRepository.Commit();
            }
            catch (Exception ex) { }
        }

        public IItemDetailDTO GetById(int id)
        {
            IItemDetailDTO itemDetailDTO = new ItemDetailDTO();
            try
            {
                IItem item = _itemRepository.GetById(id);

                itemDetailDTO.ItemId = item.Id;
                itemDetailDTO.ItemName = item.Name;

                IList<IColor> colors = _colorRepository.ListAll().ToList<IColor>();
                IList<IFabric> fabrics = _fabricRepository.ListAll().ToList<IFabric>();

                var itemColors = _itemColorRepository.GetByItemId(id);
                var itemFabrics = _itemFabricRepository.GetByItemId(id);

                itemDetailDTO.Fabrics = fabrics.Where(fabric => itemFabrics.Any(itemFabric => itemFabric.FabricId == fabric.Id))
                    .Select(x => new FabricDTO() { Id = x.Id, Name = x.Name })
                    .ToList<IFabricDTO>();
                itemDetailDTO.Colors = colors.Where(color => itemColors.Any(itemColor => itemColor.ColorId == color.Id))
                    .Select(x => new ColorDTO() { Id = x.Id, Name = x.Name })
                    .ToList<IColorDTO>();

                IList<IImage> images = _imageRepository.GetByItemId(id);

                itemDetailDTO.Images = images.Select(
                                                    x => new ImageDTO()
                                                    {
                                                        Id = x.Id,
                                                        ItemId = x.ItemId,
                                                        ItemColorId = x.ItemColorId,
                                                        ItemFabricId = x.ItemFabricId,
                                                        Image64 = x.Image64
                                                    }
                                                    ).ToList<IImageDTO>();
            }
            catch (Exception) { }

            return itemDetailDTO;
        }

        public IList<IItemListDTO> ListAllItems()
        {
            IList<IItemListDTO> itemsList = new List<IItemListDTO>();

            try
            {
                IList<IItem> items = _itemRepository.ListAll().ToList<IItem>();

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
            }
            catch (Exception ex) { }

            return itemsList;
        }

        public void RemoveImage(int imageId)
        {
            try
            {
                _imageRepository.Delete(imageId);

                _imageRepository.Commit();
            }
            catch (Exception ex) { }
        }
    }
}
