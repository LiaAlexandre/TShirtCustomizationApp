using TShirtCustomizationApp.Service.DTOs.Interfaces;

namespace TShirtCustomizationApp.Service.DTOs
{
    public class ImageDTO: IImageDTO
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int ItemColorId { get; set; }

        public int ItemFabricId { get; set; }

        public string Image64 { get; set; }
    }
}
