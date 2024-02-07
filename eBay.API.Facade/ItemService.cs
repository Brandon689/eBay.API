using eBay.API.Enums;
using eBay.API.Models;
using eBay.API.Models.Items;
using eBay.API.Models.Requests;
using eBay.API.Models.Requests.Listing;
using eBay.API.Models.Requests.Metadata;
using eBay.API.Models.Requests.Order;
using eBay.API.Models.Requests.UserAccount;
using eBay.API.Models.Response;
using eBay.API.Models.Response.Metadata;
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

        public async ValueTask<GetAccountResponse> CompleteSale()
        {
            CompleteSaleRequest request = new CompleteSaleRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                FeedbackInfo = new FeedbackInfo()
                {
                    CommentText = "good buyer",
                    CommentType = "Positive",
                    TargetUser = "user123"
                },
                Shipped = true
            };
            string response = await xs.SendEbayRequest("CompleteSale",
                xs.SerializeToXml(request));
            //File.WriteAllText("../../../account.xml", response);
            return xs.DeserializeXmlToObject<GetAccountResponse>(response);
        }

        public async ValueTask<GetAccountResponse> GetAccount(DateTime beginTime, DateTime endTime)
        {
            GetAccountRequest request = new GetAccountRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ExcludeBalance = false,
                ExcludeSummary = false,
                IncludeConversionRate = true,
                IncludeNettedEntries = true,
                BeginDate = DateTimeStr.Format(beginTime),
                EndDate = DateTimeStr.Format(endTime),
            };
            string response = await xs.SendEbayRequest("GetAccount",
                xs.SerializeToXml(request));
            //File.WriteAllText("../../../account.xml", response);
            return xs.DeserializeXmlToObject<GetAccountResponse>(response);
        }

        public async ValueTask<GetUserResponse> GetUser()
        {
            GetUserRequest request = new GetUserRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials()
            };
            string response = await xs.SendEbayRequest("GetUser",
                xs.SerializeToXml(request));
            //File.WriteAllText("../../../user.xml", response);
            return xs.DeserializeXmlToObject<GetUserResponse>(response);
        }

        public async ValueTask<GetCategoryFeaturesResponse> GetCategoryFeatures()
        {
            GetCategoryFeaturesRequest request = new GetCategoryFeaturesRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                DetailLevel = "ReturnAll",
                AllFeaturesForCategory = true,
                ViewAllNodes = true
            };
            string response = await xs.SendEbayRequest("GetCategoryFeatures",
                xs.SerializeToXml(request));
            //File.WriteAllText("../../../catfeature.xml", response);
            return xs.DeserializeXmlToObject<GetCategoryFeaturesResponse>(response);
        }

        public async ValueTask<GeteBayDetailsResponse> GeteBayDetails()
        {
            GeteBayDetailsRequest request = new GeteBayDetailsRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials()
            };
            string response = await xs.SendEbayRequest("GeteBayDetails",
                xs.SerializeToXml(request));
            return xs.DeserializeXmlToObject<GeteBayDetailsResponse>(response);
        }

        public async ValueTask<GeteBayOfficialTimeResponse> GeteBayOfficialTime()
        {
            GeteBayOfficialTimeRequest request = new GeteBayOfficialTimeRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials()
            };
            string response = await xs.SendEbayRequest("GeteBayOfficialTime",
                xs.SerializeToXml(request));

            return xs.DeserializeXmlToObject<GeteBayOfficialTimeResponse>(response);
        }

        public async ValueTask<GetSellerTransactionsResponse> GetSellerTransactions()
        {
            GetSellerTransactionsRequest request = new GetSellerTransactionsRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                DetailLevel = DetailLevelCodeType.ReturnAll
            };
            string response = await xs.SendEbayRequest("GetSellerTransactions",
                xs.SerializeToXml(request));
            return xs.DeserializeXmlToObject<GetSellerTransactionsResponse>(response);
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
                },
                OutputSelectors = new List<OutputSelector>()
                {
                    //new OutputSelector("Title"),
                    new OutputSelector("ItemID"),
                    //new OutputSelector("QuantityAvailable"),
                    new OutputSelector("Quantity"),
                    new OutputSelector("SKU"),
                    //new OutputSelector("StartPrice"),
                    new OutputSelector("BuyItNowPrice"),
                }
            };
            string response = await xs.SendEbayRequest("GetSellerList",
                xs.SerializeToXml(getSellerList));
            return xs.DeserializeXmlToObject<GetSellerListResponse>(response);
        }

        public async ValueTask<GetMyeBaySellingResponse> GetMyeBaySelling()
        {
            GetMyeBaySellingRequest getMyeBaySelling = new GetMyeBaySellingRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                ActiveList = new ActiveList()
                {
                    Sort = "TimeLeft"
                },
                SoldList = new SoldList()
                {
                },
                ScheduledList = new ScheduledList()
                {
                },
                UnsoldList = new UnsoldList(),
                DeletedFromSoldList = new DeletedFromSoldList(),

            };
            string response = await xs.SendEbayRequest("GetMyeBaySelling",
                xs.SerializeToXml(getMyeBaySelling));
            File.WriteAllText("../../../Getmysellingre.xml", xs.SerializeToXml(getMyeBaySelling));
            File.WriteAllText("../../../Getmyselling.xml", response);
            return xs.DeserializeXmlToObject<GetMyeBaySellingResponse>(response);
        }

        public async ValueTask<GetOrdersResponse> GetOrders(DateTime createTimeFrom, DateTime createTimeTo, int entriesPerPage, int pageNumber)
        {
            GetOrdersRequest getOrders = new GetOrdersRequest()
            {
                RequesterCredentials = xs.GetRequesterCredentials(),
                CreateTimeFrom = DateTimeStr.Format(createTimeFrom),
                CreateTimeTo = DateTimeStr.Format(createTimeTo),
                IncludeFinalValueFee = true,
                Pagination = new Pagination()
                {
                    EntriesPerPage = entriesPerPage,
                    PageNumber = pageNumber
                }
            };
            string response = await xs.SendEbayRequest("GetOrders",
                xs.SerializeToXml(getOrders));
            File.WriteAllText("../../../orders.xml", response);
            return xs.DeserializeXmlToObject<GetOrdersResponse>(response);
        }
    }
}