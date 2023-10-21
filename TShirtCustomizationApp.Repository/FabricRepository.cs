using System.Data.Entity;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class FabricRepository : AbstractRepository, IRepository<IEntity>
    {
        public FabricRepository(DbContext context) : base(context)
        {
        }
    }
}