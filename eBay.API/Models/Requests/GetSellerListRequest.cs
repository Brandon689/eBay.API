using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{
    public class GetSellerListRequest
    {
        public RequesterCredentials RequesterCredentials { get; set; }

        public string EndTimeFrom { get; set; }

        public string EndTimeTo { get; set; }

        public Pagination Pagination { get; set; }

        public string DetailLevel { get; set; } = "ReturnAll";
    }
}