using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IItemColorRepository<IItemColor> : IRepository<IEntity>
    {
        public IList<IItemColor> GetByItemId (int itemId);
    }
}
