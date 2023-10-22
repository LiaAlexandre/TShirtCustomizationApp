using System.Data.Entity;
using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class ImageRepository : AbstractRepository<Image>, IImageRepository
    {
        public ImageRepository(AppDbContext context) : base(context)
        {
        }

        public IList<IImage> GetByItemId(int itemId)
        {
            return _context.Set<Image>().
            Where(ic => ic.ItemId == itemId)
                    .ToList<IImage>();
        }
    }
}