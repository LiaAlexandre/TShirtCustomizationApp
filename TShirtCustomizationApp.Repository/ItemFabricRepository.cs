using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class ItemFabricRepository : AbstractRepository, IItemFabricRepository<IItemFabric>
    {
        public ItemFabricRepository(DbContext context) : base(context)
        {
        }

        public IList<IItemFabric> GetByItemId(int itemId)
        {
            return _context.Set<IItemFabric>().
            Where(ic => ic.Id == itemId)
                    .ToList();
        }
    }
}
