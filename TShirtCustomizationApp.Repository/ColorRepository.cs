using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class ColorRepository : AbstractRepository<Color>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
