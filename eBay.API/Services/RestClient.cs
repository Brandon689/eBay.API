using System.Net.Http.Headers;
using System.Text;

namespace eBay.API
{
    public class RestClient
    {
        private readonly HttpClient httpClient = new();

        public RestClient()
        {
            httpClient.BaseAddress = new Uri("https://api.ebay.com/ws/api.dll");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
            httpClient.DefaultRequestHeaders.Add("X-EBAY-API-SITEID", "15");
            httpClient.DefaultRequestHeaders.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "1331");
        }

        public async Task<string> SendHttpRequest(string req, string xml, HttpMethod hp)
        {
            HttpRequestMessage request = new HttpRequestMessage(hp, "");
            request.Headers.Remove("X-EBAY-API-CALL-NAME");
            request.Headers.Add("X-EBAY-API-CALL-NAME", req);
            request.Content = new StringContent(xml, Encoding.UTF8, "text/xml");
            try
            {
                var res = await httpClient.SendAsync(request);
                var content = await res.Content.ReadAsStringAsync();
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
