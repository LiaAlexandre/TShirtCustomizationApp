namespace TShirtCustomizationApp.Web.Models
{
    public class AddImageModel
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int ColorId { get; set; }

        public int FabricId { get; set; }

        public string Image64 { get; set; }
    }
}
