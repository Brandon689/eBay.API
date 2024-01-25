using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    public class GetOrdersRequest : GetBase
    {
        public string CreateTimeFrom { get; set; }

        public string CreateTimeTo { get; set; }

        public string OrderRole { get; set; } = "Seller";

        public Pagination Pagination { get; set; }
    }
}
