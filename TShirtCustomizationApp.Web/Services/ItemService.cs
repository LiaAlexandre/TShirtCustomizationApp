using Newtonsoft.Json;
using TShirtCustomizationApp.Web.Helpers;
using TShirtCustomizationApp.Web.Models;
using TShirtCustomizationApp.Web.Services.Interfaces;

namespace TShirtCustomizationApp.Web.Services
{
    public class ItemService : IItemService
    {
        public void AddImage(AddImageModel image, IFormFile imageFile)
        {
            using (var client = new HttpClient())
            {
                var url = "http://localhost:5293";
                var method = "Item/AddImage";

                var stringPayload = JsonConvert.SerializeObject(image);
                var httpContent = JsonContent.Create(image);

                var response = HttpClientHelper.ExecuteRequest(url, method, HttpMethod.Post, httpContent);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("Error: " + response.StatusCode);
                }
            }
        }

        public void RemoveImage(int imageId) 
        {
            var url = "http://localhost:5293" ;
            var method = "Item/RemoveImage?imageId=" + imageId;
            var result = HttpClientHelper.ExecuteRequest(url, method, HttpMethod.Delete);

        }

        public async Task<ItemDetailsViewModel> GetById(int itemId)
        {
            var url = "http://localhost:5293";
            var method = "Item/GetById/" + itemId;
            var result = HttpClientHelper.ExecuteRequest(url, method, HttpMethod.Get);

            if (result != null)
            {
                if (result.IsSuccessStatusCode)
                {
                    string content = await result.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(content))
                    {
                        ItemDetailsViewModel itemDetail = JsonConvert.DeserializeObject<ItemDetailsViewModel>(content);
                        return itemDetail;
                    }
                    else
                    {
                        return new ItemDetailsViewModel();
                    }
                }
                else
                {
                    throw new HttpRequestException("Error: " + result.StatusCode);
                }
            }
            else
            {
                throw new HttpRequestException("Error: Not Found");
            }
        }



        public async Task<List<ItemListViewModel>> ListAllAsync()
        {
            var url = "http://localhost:5293";
            var method = "Item/ListAll";

            var result = HttpClientHelper.ExecuteRequest(url, method, HttpMethod.Get);

            if (result != null)
            {
                if (result.IsSuccessStatusCode)
                {
                    string content = await result.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(content))
                    {
                        List<ItemListViewModel> list = JsonConvert.DeserializeObject<List<ItemListViewModel>>(content);
                        return list;
                    }
                    else
                    {
                        return new List<ItemListViewModel>();
                    }
                }
                else
                {
                    throw new HttpRequestException("Error: " + result.StatusCode);
                }
            }
            else
            {
                throw new HttpRequestException("Error: Not Found");
            }
        }

    }
}

