namespace TShirtCustomizationApp.Web.Models
{
    public class ItemDetailsViewModel
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public List<FabricModel> Fabrics { get; set; }

        public List<ColorModel> Colors { get; set; }

        public List<ImageModel> Images { get; set; }
    }
}
