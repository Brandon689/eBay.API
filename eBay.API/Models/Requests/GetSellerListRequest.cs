using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{
    public class GetSellerListRequest : GetBase
    {
        public string EndTimeFrom { get; set; }

        public string EndTimeTo { get; set; }

        public Pagination Pagination { get; set; }
    }
}