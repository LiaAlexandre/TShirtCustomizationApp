using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IItemFabricRepository : IRepository<ItemFabric>
    {
        public IList<IItemFabric> GetByItemId(int itemId);
    }
}
