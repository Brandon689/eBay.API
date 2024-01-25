using eBay.API.Enums;
using eBay.API.Models;
using eBay.API.Models.Requests;
using eBay.API.Models.Response;
using eBay.API.Models.SellerStore;
using System.Collections.Concurrent;
using System.Net;
using System.Text;
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
            string response = await xs.SendEbayRequest("UploadSiteHostedPictures", xs.SerializeToXml(request));
            return xs.DeserializeXmlToObject<UploadSiteHostedPicturesResponse>(response);
        }

        public async ValueTask<string> GetSellerTransactions()
        {
            GetSellerTransactionsRequest request = new GetSellerTransactionsRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                DetailLevel = DetailLevelCodeType.ReturnAll
            };
            string response = await xs.SendEbayRequest("GetSellerTransactions",
                xs.SerializeToXml(request));
            return response;
        }

        public async ValueTask<EndFixedPriceItemResponse> EndItem(string itemId)
        {
            EndFixedPriceItemRequest request = new EndFixedPriceItemRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ItemID = itemId,
                EndingReason = EndReasonCodeType.NotAvailable
            };

            string response = await xs.SendEbayRequest("EndFixedPriceItem",
                xs.SerializeToXml(request));
            return xs.DeserializeXmlToObject<EndFixedPriceItemResponse>(response);
        }

        public async ValueTask<ReviseItemResponse> ReviseFixedPriceItem(Item item)
        {
            ReviseItemRequest request = new ReviseItemRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                Item = item
            };
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
            string response = await xs.SendEbayRequest("AddFixedPriceItem",
                xs.SerializeToXml(request));

            return xs.DeserializeXmlToObject<AddFixedPriceItemResponse>(response);
        }

        public async ValueTask<VerifyAddFixedPriceItemResponse> VerifyAddFixedPriceItem(Item item)
        {
            VerifyAddFixedPriceItemRequest request = new VerifyAddFixedPriceItemRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                Item = item
            };

            string response = await xs.SendEbayRequest("VerifyAddFixedPriceItem",
                xs.SerializeToXml(request));

            return xs.DeserializeXmlToObject<VerifyAddFixedPriceItemResponse>(response);
        }

        public async ValueTask<GetItemResponse> GetItem(string itemId)
        {
            GetItemRequest getItemRequest = new GetItemRequest
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ItemID = itemId,
                OutputSelectors = new List<OutputSelector>()
                {
                    new OutputSelector("Title"),
                    new OutputSelector("ItemID"),
                    new OutputSelector("QuantityAvailable"),
                    new OutputSelector("StartPrice"),
                }
            };
            string response = await xs.SendEbayRequest("GetItem",
                xs.SerializeToXml(getItemRequest));
            return xs.DeserializeXmlToObject<GetItemResponse>(response);
        }

        public async ValueTask<GetCategoriesResponse> GetCategories(bool viewAllNodes = true, int categoryParent = -1, int levelLimit = -1)
        {
            GetCategoriesRequest getCategories = new GetCategoriesRequest
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ViewAllNodes = viewAllNodes,
                DetailLevel = "ReturnAll",
                LevelLimit = levelLimit == -1 ? null : levelLimit.ToString(),
                CategoryParent = categoryParent.ToString(),
                CategorySiteID = "15"//categorySiteId.ToString()
            };
            string response = await xs.SendEbayRequest("GetCategories",
                xs.SerializeToXml(getCategories));
            File.WriteAllText("../../../getCategoriesREQ.xml", xs.SerializeToXml(getCategories));
            File.WriteAllText("../../../getCategoriesRE.xml", response);

            return xs.DeserializeXmlToObject<GetCategoriesResponse>(response);
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
            string response = await xs.SendEbayRequest("GetOrders",
                xs.SerializeToXml(getOrders));
            return xs.DeserializeXmlToObject<GetOrdersResponse>(response);
        }

    }
}

