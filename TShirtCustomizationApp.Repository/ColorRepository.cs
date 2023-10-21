using System.Data.Entity;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class ColorRepository : AbstractRepository, IRepository<IEntity>
    {
        public ColorRepository(DbContext context) : base(context)
        {
        }
    }
}