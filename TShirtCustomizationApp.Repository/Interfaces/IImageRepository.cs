using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IImageRepository : IRepository<Image>
    {
        public IList<IImage> GetByItemId(int itemId);
    }
}
