using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{
    public class GetOrdersRequest
    {
        public RequesterCredentials RequesterCredentials { get; set; }

        public string DetailLevel { get; set; } = "ReturnAll";

        public string CreateTimeFrom { get; set; }

        public string CreateTimeTo { get; set; }

        public string OrderRole { get; set; } = "Seller";

        public Pagination Pagination { get; set; }
    }
}
