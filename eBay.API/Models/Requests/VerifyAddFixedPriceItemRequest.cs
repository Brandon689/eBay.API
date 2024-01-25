using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{//https://developer.ebay.com/devzone/xml/docs/reference/ebay/AddFixedPriceItem.html
    public class VerifyAddFixedPriceItemRequest : AllBase
    {
        public Item Item { get; set; }
    }
}
