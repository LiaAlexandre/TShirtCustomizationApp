using System.Net.Http.Headers;

namespace TShirtCustomizationApp.Web.Helpers
{
    public static class HttpClientHelper
    {
        public static System.Net.Http.HttpResponseMessage ExecuteRequest(string baseUrl, string method, HttpMethod httpMethod, HttpContent httpContent = null)
        {
            using HttpClient client = new();

            string url = $"{baseUrl}/{method}";

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            if (httpMethod == HttpMethod.Get)
            {
                return client.GetAsync(url).Result;
            }
            else if(httpMethod == HttpMethod.Post)
            {
                return client.PostAsync(url, httpContent).Result;
            }

            return client.DeleteAsync(url).Result;
        }
    }
}
