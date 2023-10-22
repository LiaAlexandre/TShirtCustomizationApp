namespace TShirtCustomizationApp.Entity.Interfaces
{
    public interface IItemColor : IEntity
    {

        public int ItemId { get; set; }

        public int ColorId { get; set; }
    }
}
