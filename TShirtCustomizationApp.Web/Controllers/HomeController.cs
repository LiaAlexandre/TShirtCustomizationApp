using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TShirtCustomizationApp.Web.Models;
using TShirtCustomizationApp.Web.Services.Interfaces;

namespace TShirtCustomizationApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IItemService _itemService;

        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            List<ItemListViewModel> itemListViewModel = new List<ItemListViewModel>();

            var result = _itemService.ListAllAsync();

            foreach (var item in result.Result)
            {
                ItemListViewModel itemList = new ItemListViewModel();

                itemList.FabricsCount = item.FabricsCount;
                itemList.ColorsCount = item.ColorsCount;
                itemList.ImagesCount = item.ImagesCount;
                itemList.ItemName = item.ItemName;
                itemList.ItemId = item.ItemId;

                itemListViewModel.Add(itemList);
            }

            return View(itemListViewModel);
        }

        public IActionResult EditImages(int itemId)
        {
            var result = _itemService.GetById(itemId);

            return View(result.Result);
        }

        public IActionResult RemoveImage(int imageId)
        {
            if (imageId != 0)
            {
                _itemService.RemoveImage(imageId);
            }

            return RedirectToAction("Index");
        }

        public IActionResult AddImage(int itemId, int colorId, int fabricId, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                if (IsImage(imageFile))
                {
                    string base64Image = ConvertToBase64(imageFile);

                    AddImageModel image = new AddImageModel();
                    image.ItemId = itemId;
                    image.ColorId = colorId;
                    image.FabricId = fabricId;
                    image.Image64 = base64Image;

                    _itemService.AddImage(image, imageFile);
                }
            }
            return RedirectToAction("Index");
        }

        private bool IsImage(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                string[] allowedFileTypes = { "image/jpeg", "image/jpg", "image/png", "image/gif" };
                return allowedFileTypes.Contains(file.ContentType);
            }
            return false;
        }

        private string ConvertToBase64(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                byte[] bytes = memoryStream.ToArray();
                return Convert.ToBase64String(bytes);
            }
        }

    }
}