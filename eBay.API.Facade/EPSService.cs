using eBay.API.Models.Requests;
using System.Net.Http.Headers;
using System.Text;

namespace eBay.API.Facade
{
    public class EPSService
    {
        private HttpClient client;
        private XMLS xs;

        public EPSService(XMLS t)
        {
            xs = t;
            client = new HttpClient();
        }

        public async Task Custom(string file)
        {
            UploadSiteHostedPicturesRequest obj = new UploadSiteHostedPicturesRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                PictureSet = "SuperSize",
                WarningLevel = "High",
                ErrorLanguage = "en-US",
                PictureName = "Developer Page Banner"
            };
            string xmlPayload = xs.SerializeToXml(obj);

            using var request = new HttpRequestMessage(HttpMethod.Post, "https://api.ebay.com/ws/api.dll");
            request.Headers.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "1331");
            request.Headers.Add("X-EBAY-API-SITEID", "15");
            request.Headers.Add("X-EBAY-API-DETAIL-LEVEL", "0");
            request.Headers.Add("X-EBAY-API-CALL-NAME", "UploadSiteHostedPictures");

            var boundary = "2f96a731-ef48-4599-a6bf-c4a8d81fa15a";

            using var content = new MemoryStream();
            using (var writer = new StreamWriter(content, new UTF8Encoding(false), 1024, true))
            {
                await writer.WriteAsync("--" + boundary + "\r\n").ConfigureAwait(false);

                // XML part
                await writer.WriteAsync("Content-Disposition: form-data; name=\"document\"\r\nContent-Type: text/xml; charset=UTF-8\r\n\r\n" + xmlPayload + "\r\n").ConfigureAwait(false);
                //await writer.WriteAsync("").ConfigureAwait(false);
                
                //writer.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?><UploadSiteHostedPicturesRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\"><RequesterCredentials><eBayAuthToken xmlns=\"urn:ebay:apis:eBLBaseComponents\">v^1.1#i^1#r^1#f^0#I^3#p^3#t^Ul4xMF8yOkQ1OTZCM0UxMEIxRDY2NjAwRUFGMTZFRTE2RTFCM0Y5XzBfMSNFXjI2MA==</eBayAuthToken></RequesterCredentials><PictureName>Gall-Peters projection map</PictureName><PictureSet>Standard</PictureSet><ExtensionInDays>20</ExtensionInDays></UploadSiteHostedPicturesRequest>\r\n");
                //writer.Write(xmlPayload + "\r\n");
                
                await writer.FlushAsync().ConfigureAwait(false);

                // Image part
                await writer.WriteAsync("--" + boundary + "\r\n").ConfigureAwait(false);
                await writer.WriteAsync("Content-Disposition: form-data; name=\"image\"; filename=\"vtuber.jpg\"\r\nContent-Type: application/octet-stream\r\n\r\n").ConfigureAwait(false);
                //await writer.WriteAsync("").ConfigureAwait(false);
                await writer.FlushAsync().ConfigureAwait(false);

                // Add image binary data
                var image = File.ReadAllBytes(file);
                await content.WriteAsync(image, 0, image.Length).ConfigureAwait(false);
                await writer.FlushAsync().ConfigureAwait(false);

                await writer.WriteAsync("\r\n--" + boundary + "--\r\n").ConfigureAwait(false);
                await writer.FlushAsync().ConfigureAwait(false);
            }
            request.Content = new ByteArrayContent(content.ToArray());
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse($"multipart/form-data; boundary={boundary}");
            try
            {
                var response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
            }
            catch (HttpRequestException e)
            {
                // Handle exceptions related to the HTTP request
                Console.WriteLine($"Error making HTTP request: {e.Message}");
            }
        }
    }
}
