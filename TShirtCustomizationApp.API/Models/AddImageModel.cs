namespace TShirtCustomizationApp.API.Models
{
    public class AddImageModel
    {
        public int? ItemId { get; set; }

        public string Filename { get; set; }

        public int? ColorId { get; set; }

        public int? FabricId { get; set; }

        public string Image64 { get; set; }
    }
}
