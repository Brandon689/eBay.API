using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{
    public class ReviseItemRequest : ReviseBase
    {
        public Item Item { get; set; }
    }
}
