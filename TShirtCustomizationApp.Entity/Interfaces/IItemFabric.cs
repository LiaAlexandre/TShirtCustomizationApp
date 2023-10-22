namespace TShirtCustomizationApp.Entity.Interfaces
{
    public interface IItemFabric : IEntity
    {
        public int ItemId { get; set; }
        public int FabricId { get; set; }
    }
}
