namespace TShirtCustomizationApp.Service.DTOs.Interfaces
{
    public interface IItemDetailDTO
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public List<IFabricDTO> Fabrics { get; set; }

        public List<IColorDTO> Colors { get; set; }

        public List<IImageDTO> Images { get; set; }
    }
}
