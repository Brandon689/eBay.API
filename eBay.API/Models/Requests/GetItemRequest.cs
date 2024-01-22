using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{
    public class GetItemRequest
    {
        public RequesterCredentials RequesterCredentials { get; set; }

        public string DetailLevel { get; set; } = "ReturnAll";

        public string ItemID { get; set; }
    }
}
