using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class ItemColorRepository : AbstractRepository<ItemColor>, IItemColorRepository
    {
        public ItemColorRepository(AppDbContext context) : base(context)
        {
        }

        public IList<IItemColor> GetByItemId(int itemId)
        {
            return _context.Set<ItemColor>().
            Where(ic => ic.ItemId == itemId)
                    .ToList<IItemColor>();
        }
    }
}
