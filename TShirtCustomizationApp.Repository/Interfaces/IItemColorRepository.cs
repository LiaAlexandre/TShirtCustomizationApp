using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IItemColorRepository : IRepository<ItemColor>
    {
        public IList<IItemColor> GetByItemId (int itemId);
    }
}
