using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity
{
    public class ItemColor : IItemColor
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int ColorId { get; set; }
    }
}
