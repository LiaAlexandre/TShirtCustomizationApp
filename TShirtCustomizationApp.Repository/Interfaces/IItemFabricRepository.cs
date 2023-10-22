using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IItemFabricRepository : IRepository<ItemFabric>
    {
        public IList<IItemFabric> GetByItemId(int itemId);
    }
}
