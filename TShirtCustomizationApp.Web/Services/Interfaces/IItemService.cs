using TShirtCustomizationApp.Web.Models;

namespace TShirtCustomizationApp.Web.Services.Interfaces
{
    public interface IItemService
    {
        Task<ItemDetailsViewModel> GetById(int itemId);
        Task<List<ItemListViewModel>> ListAllAsync();
        void RemoveImage(int imageId);
        void AddImage(AddImageModel image, IFormFile imageFile);
    }
}
