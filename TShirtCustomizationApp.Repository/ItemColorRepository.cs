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
    public class ItemColorRepository : AbstractRepository, IItemColorRepository<IItemColor>
    {
        public ItemColorRepository(DbContext context) : base(context)
        {
        }

        public IList<IItemColor> GetByItemId(int itemId)
        {
            return _context.Set<IItemColor>().
            Where(ic => ic.Id == itemId)
                    .ToList();
        }
    }
}
