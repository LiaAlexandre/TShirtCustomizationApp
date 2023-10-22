using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{

    public class ItemFabricRepository : AbstractRepository<ItemFabric>, IItemFabricRepository
    {
        public ItemFabricRepository(AppDbContext context) : base(context)
        {
        }

        public IList<IItemFabric> GetByItemId(int itemId)
        {
            return _context.Set<ItemFabric>().
            Where(ic => ic.ItemId == itemId)
                    .ToList<IItemFabric>();
        }
    }
}
