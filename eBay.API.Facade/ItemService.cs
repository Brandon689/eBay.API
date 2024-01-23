using eBay.API.Enums;
using eBay.API.Models;
using eBay.API.Models.Requests;
using eBay.API.Models.Response;
using eBay.API.Models.SellerStore;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace eBay.API.Facade
{
    public class ItemService
    {
        private XMLS xs;
        private static readonly ConcurrentDictionary<Type, XmlSerializer> serializerCache = new ConcurrentDictionary<Type, XmlSerializer>();

        public ItemService(XMLS t)
        {
            xs = t;
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
            var v = xs.SerializeToXml(request);
            File.WriteAllText("../../../UploadSiteHostedPicturesRequest.xml", v);
            string response = await xs.SendEbayRequest("UploadSiteHostedPictures", xs.SerializeToXml(request));
            File.WriteAllText("../../../UploadSiteHostedPictures.xml", response);

            return xs.DeserializeXmlToObject<UploadSiteHostedPicturesResponse>(response);
        }

        public async ValueTask<string> GetSellerTransactions()
        {
            GetSellerTransactionsRequest request = new GetSellerTransactionsRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                DetailLevel = DetailLevelCodeType.ReturnAll
            };
            var v = xs.SerializeToXml(request);
            File.WriteAllText("../../../GetSellerTransactionsRequest.xml", v);
            string response = await xs.SendEbayRequest("GetSellerTransactions",
                xs.SerializeToXml(request));
            File.WriteAllText("../../../GetSellerTransactions.xml", response);
            return response;
            //return xs.DeserializeXmlToObject<EndFixedPriceItemResponse>(response);
        }

        public async ValueTask<EndFixedPriceItemResponse> EndItem(string itemId)
        {
            EndFixedPriceItemRequest request = new EndFixedPriceItemRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ItemID = itemId,
                EndingReason = EndReasonCodeType.NotAvailable
            };
            var v = xs.SerializeToXml(request);
            //File.WriteAllText("../../../revise.xml", v);
            string response = await xs.SendEbayRequest("EndFixedPriceItem",
                xs.SerializeToXml(request));
            //File.WriteAllText("../../../EndFixedPriceItem.xml", response);
            return xs.DeserializeXmlToObject<EndFixedPriceItemResponse>(response);
        }

        public async ValueTask<ReviseItemResponse> ReviseFixedPriceItem(Item item)
        {
            ReviseItemRequest request = new ReviseItemRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                Item = item
            };
            var v = xs.SerializeToXml(request);
            File.WriteAllText("../../../revise.xml", v);
            string response = await xs.SendEbayRequest("ReviseItem",
                xs.SerializeToXml(request));

            return xs.DeserializeXmlToObject<ReviseItemResponse>(response);
        }

        public async ValueTask<AddFixedPriceItemResponse> AddFixedPriceItem(Item item)
        {
            AddFixedPriceItemRequest request = new AddFixedPriceItemRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                Item = item
            };

            File.WriteAllText("../../../o.xml", xs.SerializeToXml(request));

            string response = await xs.SendEbayRequest("AddFixedPriceItem",
                xs.SerializeToXml(request));

            File.WriteAllText("../../../ListFixedPriceItemW2Variation.xml", response);

            return xs.DeserializeXmlToObject<AddFixedPriceItemResponse>(response);
        }

        public async ValueTask<VerifyAddFixedPriceItemResponse> VerifyAddFixedPriceItem(Item item)
        {
            VerifyAddFixedPriceItemRequest request = new VerifyAddFixedPriceItemRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                Item = item
            };

            //Pretty.Lock("VerifyAddFixedPriceItemRequest", xs.SerializeToXml(request));
            //File.WriteAllText("../../../VerifyAddFixedPriceItemRequest.xml", xs.SerializeToXml(request));

            string response = await xs.SendEbayRequest("VerifyAddFixedPriceItem",
                xs.SerializeToXml(request));

            //File.WriteAllText("../../../VerifyAddFixedPriceItem.xml", response);
            //Pretty.Lock("VerifyAddFixedPriceItem", xs.SerializeToXml(response));

            return xs.DeserializeXmlToObject<VerifyAddFixedPriceItemResponse>(response);
        }

        public async ValueTask<GetItemResponse> GetItem(string itemId)
        {
            GetItemRequest getItemRequest = new GetItemRequest
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ItemID = itemId
            };
            string response = await xs.SendEbayRequest("GetItem",
                xs.SerializeToXml(getItemRequest));
            File.WriteAllText("../../../GetItemResponse.xml", response);
            return xs.DeserializeXmlToObject<GetItemResponse>(response);
        }

        public async ValueTask<GetSellerListResponse> GetSellerList(DateTime endTimeFrom, DateTime endTimeTo, int entriesPerPage, int pageNumber)
        {
            GetSellerListRequest getSellerList = new GetSellerListRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                EndTimeFrom = DateTimeStr.Format(endTimeFrom),
                EndTimeTo = DateTimeStr.Format(endTimeTo),
                Pagination = new Pagination()
                {
                    EntriesPerPage = entriesPerPage,
                    PageNumber = pageNumber
                }
            };
            string response = await xs.SendEbayRequest("GetSellerList",
                xs.SerializeToXml(getSellerList));
            return xs.DeserializeXmlToObject<GetSellerListResponse>(response);
        }

        public async ValueTask<GetOrdersResponse> GetOrders(DateTime createTimeFrom, DateTime createTimeTo, int entriesPerPage, int pageNumber)
        {
            GetOrdersRequest getOrders = new GetOrdersRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                CreateTimeFrom = DateTimeStr.Format(createTimeFrom),
                CreateTimeTo = DateTimeStr.Format(createTimeTo),
                Pagination = new Pagination()
                {
                    EntriesPerPage = entriesPerPage,
                    PageNumber = pageNumber
                }
            };
            File.WriteAllText("../../../orders.xml", xs.SerializeToXml(getOrders));
            string response = await xs.SendEbayRequest("GetOrders",
                xs.SerializeToXml(getOrders));
            return xs.DeserializeXmlToObject<GetOrdersResponse>(response);
        }




        //public async ValueTask<string> UploadImage9()
        //{
        //    UploadSiteHostedPicturesRequest request = new()
        //    {
        //        RequesterCredentials = xs.GetRequesterCredentials(),
        //        PictureSet = "SuperSize",
        //    };
        //    string url = "https://api.ebay.com/ws/api.dll";
        //    string imagePath = @"C:\Users\Brandon\Pictures\zz\370390853_721677449700532_4243546140319382729_n.jpg";
        //    string xmlPayload = xs.SerializeToXml(request);

        //    // Initialize HttpClient
        //    using (HttpClient client = new HttpClient())
        //    {
        //        // Prepare request headers
        //        client.DefaultRequestHeaders.Add("X-EBAY-API-CALL-NAME", "UploadSiteHostedPictures");
        //        client.DefaultRequestHeaders.Add("X-EBAY-API-SITEID", "15");
        //        client.DefaultRequestHeaders.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "967");
        //        client.DefaultRequestHeaders.Add("X-EBAY-API-RESPONSE-ENCODING", "XML");


        //        //client.Headers.Add("X-EBAY-API-SITEID", "15");
        //        //client.Headers.Add("X-EBAY-API-DETAIL-LEVEL", "0");
        //        //client.Headers.Add("X-EBAY-API-CALL-NAME", "UploadSiteHostedPictures");
        //        //client.ContentType = "multipart/form-data; boundary=" + boundary;
        //        //client.Method = "POST";

        //        StringBuilder sb = new StringBuilder();
        //        sb.AppendLine("This is a multiline string.");
        //        sb.AppendLine("It spans several lines.");
        //        sb.AppendLine("Each new line is appended elegantly.");

        //        string multilineString = sb.ToString();

        //        // Create a MultipartFormDataContent
        //        using (var content = new MultipartFormDataContent("----FormBoundary7MA4YWxkTrZu0gW"))
        //        {
        //            // Add XML payload
        //            var xmlContent = new StringContent(xmlPayload, Encoding.UTF8, "text/xml");
        //            content.Add(xmlContent, "XML Payload");

        //            // Add binary image
        //            var imageContent = new ByteArrayContent(File.ReadAllBytes(imagePath));
        //            imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
        //            content.Add(imageContent, "file", Path.GetFileName(imagePath));

        //            // Send POST request
        //            HttpResponseMessage response = await client.PostAsync(url, content);

        //            // Check response
        //            if (response.IsSuccessStatusCode)
        //            {
        //                string responseBody = await response.Content.ReadAsStringAsync();
        //                Console.WriteLine(responseBody);
        //                // Process the response here
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Error: {response.StatusCode}");
        //            }
        //        }
        //    }
        //    return "";
        //}

        //public async Task<string> UploadFileAsync2(string localFile, string authNauthToken)
        //{
        //    string CRLF = "\r\n";
        //    string boundary = "--MIME_boundary";
        //    var content = new MultipartFormDataContent(boundary);

        //    UploadSiteHostedPicturesRequest request = new()
        //    {
        //        RequesterCredentials = xs.GetRequesterCredentials(),
        //        PictureSet = "SuperSize",
        //        WarningLevel = "High",
        //        ErrorLanguage = "en-US",
        //        PictureName = "Developer Page Banner"
        //    };
        //    string url = "https://api.ebay.com/ws/api.dll";
        //    string imagePath = @"C:\Users\Brandon\Pictures\zz\370390853_721677449700532_4243546140319382729_n.jpg";
        //    string xmlPayload = xs.SerializeToXml(request);


        //    string part1 = boundary + CRLF;
        //    part1 += "Content-Disposition: form-data; name=document" + CRLF + "Content-Type: text/xml; charset=\"UTF-8\"" + CRLF + CRLF;

        //    part1 += xmlPayload;

        //    part1 += CRLF + boundary + CRLF + "Content-Disposition: form-data; name=image; filename=image" + CRLF +
        //        "Content-Type: application/octet-stream" + CRLF + "Content-Transfer-Encoding: binary" + CRLF + CRLF;


        //    content.Add(new StringContent(xmlPayload, Encoding.UTF8, "text/xml"), "document");

        //    // Image Content
        //    byte[] image = File.ReadAllBytes(localFile);
        //    var imageContent = new ByteArrayContent(File.ReadAllBytes(localFile));
        //    imageContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        //    content.Add(imageContent, "image", "image");

        //    //byte[] postDataBytes1 = Encoding.ASCII.GetBytes(part1);

        //    var client = new HttpClient(new LoggingHandler(new HttpClientHandler()));

        //    client.DefaultRequestHeaders.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "515");
        //    client.DefaultRequestHeaders.Add("X-EBAY-API-SITEID", "15");
        //    client.DefaultRequestHeaders.Add("X-EBAY-API-DETAIL-LEVEL", "0");
        //    client.DefaultRequestHeaders.Add("X-EBAY-API-CALL-NAME", "UploadSiteHostedPictures");

        //    // Send POST request
        //    HttpResponseMessage response = await client.PostAsync("https://api.ebay.com/ws/api.dll", content);

        //    if (!response.IsSuccessStatusCode)
        //    {
        //        return "";
        //    }

        //    // Read response
        //    string responseContent = await response.Content.ReadAsStringAsync();

        //    if (string.IsNullOrEmpty(responseContent))
        //        return "";

        //    XmlDocument xmlResponse = new XmlDocument();
        //    xmlResponse.LoadXml(responseContent);

        //    XmlNodeList list = xmlResponse.GetElementsByTagName("FullURL", "urn:ebay:apis:eBLBaseComponents");
        //    return list.Count > 0 ? list[0].InnerText : "";
        //}
    }
}

