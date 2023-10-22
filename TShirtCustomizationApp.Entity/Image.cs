using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity
{
    public class Image : IImage
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int ItemColorId { get; set; }

        public int ItemFabricId { get; set; }

        public string Image64 { get; set; }

        public Image(int itemId, int itemColorId, int itemFabricId, string image64)
        {
            ItemId = itemId;
            ItemColorId = itemColorId;
            ItemFabricId = itemFabricId;
            Image64 = image64;
        }
    }
}
