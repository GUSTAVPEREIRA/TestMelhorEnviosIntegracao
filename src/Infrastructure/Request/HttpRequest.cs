using System.Net.Http.Headers;
using System.Text;
using Core.Configurations.Extenstions;
using Core.Request;
using Core.Request.Models;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Request
{
    public class HttpRequest : IHttpRequest
    {
        private readonly IConfiguration _configuration;

        public HttpRequest(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private HttpClient GetHttpClientConfig(Dictionary<string, string> headers)
        {
            var client = new HttpClient();
            var settings = _configuration.GetSettings();
            client.Timeout = TimeSpan.FromSeconds(Convert.ToInt32(settings.TimeOut));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            foreach (var (key, value) in headers)
            {
                client.DefaultRequestHeaders.Add(key, value);
            }

            return client;
        }

        public async Task<string> GetRequest(BaseHttpRequest baseRequest)
        {
            using var client = GetHttpClientConfig(baseRequest.Headers);

            var response = await client.GetStringAsync(baseRequest.Url);
            return response;
        }


        public async Task<string> PostRequest(PostHttpRequest request)
        {
            using var client = GetHttpClientConfig(request.Headers);
            var response = client.PostAsync(request.Url,
                new StringContent(request.Body, Encoding.UTF8, "application/json"));

            try
            {
                response.Result.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return await response.Result.Content.ReadAsStringAsync();
        }

        public async Task<string> PutRequest(PostHttpRequest request)
        {
            using var client = GetHttpClientConfig(request.Headers);

            var response = client.PutAsync(request.Url,
                new StringContent(request.Body, Encoding.UTF8, "application/json"));

            try
            {
                response.Result.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return await response.Result.Content.ReadAsStringAsync();
        }
    }
}