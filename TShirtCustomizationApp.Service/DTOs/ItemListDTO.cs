using TShirtCustomizationApp.Service.DTOs.Interfaces;

namespace TShirtCustomizationApp.Service.DTOs
{
    public class ItemListDTO: IItemListDTO
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public int ColorsCount { get; set; }

        public int FabricsCount { get; set; }

        public int ImagesCount { get; set; }
    }
}
