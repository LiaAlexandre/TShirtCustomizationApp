using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class ItemRepository : AbstractRepository<Item>, IItemRepository
    {
        public ItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}