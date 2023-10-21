using System.Data.Entity;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class ImageRepository : AbstractRepository, IImageRepository<IImage>
    {
        public ImageRepository(DbContext context) : base(context)
        {
        }

        public IList<IImage> GetByItemId(int itemId)
        {
            return _context.Set<IImage>().
            Where(ic => ic.Id == itemId)
                    .ToList();
        }
    }
}