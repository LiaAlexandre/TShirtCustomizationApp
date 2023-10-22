using TShirtCustomizationApp.Service.DTOs.Interfaces;

namespace TShirtCustomizationApp.Service.DTOs
{
    public class ItemDetailDTO: IItemDetailDTO
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public List<IFabricDTO> Fabrics { get; set; }

        public List<IColorDTO> Colors { get; set; }

        public List<IImageDTO> Images { get; set; }

        public ItemDetailDTO()
        {
            Fabrics = new List<IFabricDTO>();
            Colors = new List<IColorDTO>();
            Images = new List<IImageDTO>();
        }
    }
}
