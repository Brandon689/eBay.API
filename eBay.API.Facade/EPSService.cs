using eBay.API.Models.Requests;
using eBay.API.Models.Response;
using System.Net;
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

        public async Task<UploadSiteHostedPicturesResponse> UploadFileWithExternalUrl()
        {
            UploadSiteHostedPicturesRequest request = new UploadSiteHostedPicturesRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ErrorLanguage = "en-US",
                WarningLevel = "High",
                ExternalPictureURL = "https://fastcdn.hoyoverse.com/mi18n/hk4e_global/m20231213hy3784dbsw/upload/839ee8c17dadff82dd16affa01d76e77_4356147439317626683.jpg",
                PictureName = "Developer Page Banner"
            };
            string response = await xs.SendEbayRequest("UploadSiteHostedPictures", xs.SerializeToXml(request));
            return xs.DeserializeXmlToObject<UploadSiteHostedPicturesResponse>(response);
        }

        public async Task<UploadSiteHostedPicturesResponse> Custom(string file)
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
                await writer.WriteAsync($"--{boundary}\r\n").ConfigureAwait(false);

                // XML part
                await writer.WriteAsync($"Content-Disposition: form-data; name=\"document\"\r\nContent-Type: text/xml; charset=UTF-8\r\n\r\n{xmlPayload}\r\n").ConfigureAwait(false);

                await writer.FlushAsync().ConfigureAwait(false);

                // Image part
                await writer.WriteAsync($"--{boundary}\r\n").ConfigureAwait(false);
                await writer.WriteAsync("Content-Disposition: form-data; name=\"image\"; filename=\"vtuber.jpg\"\r\nContent-Type: application/octet-stream\r\n\r\n").ConfigureAwait(false);
                await writer.FlushAsync().ConfigureAwait(false);

                // Add image binary data
                var image = File.ReadAllBytes(file);
                await content.WriteAsync(image, 0, image.Length).ConfigureAwait(false);
                await writer.FlushAsync().ConfigureAwait(false);

                await writer.WriteAsync($"\r\n--{boundary}--\r\n").ConfigureAwait(false);
                await writer.FlushAsync().ConfigureAwait(false);
            }

            request.Content = new ByteArrayContent(content.ToArray());
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse($"multipart/form-data; boundary={boundary}");
            try
            {
                var response = await client.SendAsync(request).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return xs.DeserializeXmlToObject<UploadSiteHostedPicturesResponse>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error making HTTP request: {e.Message}");
                throw;
            }
        }

        public UploadSiteHostedPicturesResponse UploadFile(string localFile, string authNauthToken)
        {
            string boundary = "----MIMEBoundary" + DateTime.Now.Ticks.ToString("x");

            string CRLF = "\r\n";
            HttpWebRequest? request = WebRequest.Create("https://api.ebay.com/ws/api.dll") as HttpWebRequest;
            request.Headers.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "515");
            request.Headers.Add("X-EBAY-API-SITEID", "15");
            request.Headers.Add("X-EBAY-API-DETAIL-LEVEL", "0");
            request.Headers.Add("X-EBAY-API-CALL-NAME", "UploadSiteHostedPictures");
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";

            string payload1 = boundary + CRLF +
                "Content-Disposition: form-data; name=document" + CRLF +
                "Content-Type: text/xml; charset=\"UTF-8\"" + CRLF + CRLF +
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<UploadSiteHostedPicturesRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\">" +
                "<PictureSet>Supersize</PictureSet>" +
                "<RequesterCredentials><eBayAuthToken>" + authNauthToken + "</eBayAuthToken></RequesterCredentials>" +
                "</UploadSiteHostedPicturesRequest>" +
                CRLF + "--" + boundary + CRLF +
                "Content-Disposition: form-data; name=image; filename=image" + CRLF +
                "Content-Type: application/octet-stream" + CRLF +
                "Content-Transfer-Encoding: binary" + CRLF + CRLF;

            string payload3 = CRLF + "--" + boundary + CRLF;

            byte[] postDataBytes1 = Encoding.ASCII.GetBytes(payload1);
            byte[] postDataBytes2 = Encoding.ASCII.GetBytes(payload3);
            byte[] image = File.ReadAllBytes(localFile);
            int length = postDataBytes1.Length + image.Length + postDataBytes2.Length;

            using (Stream stream = request.GetRequestStream())
            {
                byte[] bytes = postDataBytes1.Concat(image).Concat(postDataBytes2).ToArray();
                var str = Encoding.Default.GetString(bytes);
                stream.Write(bytes, 0, length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string output = string.Empty;
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                output = sr.ReadToEnd();
            }
            return xs.DeserializeXmlToObject<UploadSiteHostedPicturesResponse>(output);
        }
    }
}
