namespace TShirtCustomizationApp.Entity.Interfaces
{
    public interface IImage : IEntity
    {
        public int ItemId { get; set; }

        public int ItemColorId { get; set; }

        public int ItemFabricId { get; set; }

        public string Image64 { get; set; }
    }
}
