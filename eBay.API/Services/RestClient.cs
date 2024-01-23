using System.Text;

namespace eBay.API
{
    public class RestClient
    {
        private readonly HttpClient httpClient = new();

        public RestClient()
        {
            //httpClient.BaseAddress = new Uri("https://api.ebay.com/ws/api.dll");
            //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
            httpClient.DefaultRequestHeaders.Add("X-EBAY-API-SITEID", "15");
            httpClient.DefaultRequestHeaders.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "1331");
            //httpClient.DefaultRequestHeaders.Add("X-EBAY-API-DETAIL-LEVEL", "0");
        }

        public async Task<string> SendHttpRequest(string req, string xml)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://api.ebay.com/ws/api.dll");
            request.Headers.Remove("X-EBAY-API-CALL-NAME");
            request.Headers.Add("X-EBAY-API-CALL-NAME", req);
            request.Content = new StringContent(xml, Encoding.UTF8, "application/xml");
            //request.Content = new StringContent(xml, null, "application/xml");
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
