using eBay.API.Enums;
using eBay.API.Models;
using eBay.API.Models.Requests;
using eBay.API.Models.Response;
using eBay.API.Models.SellerStore;
using System.Collections.Concurrent;
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
    }
}

