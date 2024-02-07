using eBay.API.Models.Items;
using eBay.API.Models.Requests.Base;

namespace eBay.API.Models.Requests.Listing
{//https://developer.ebay.com/devzone/xml/docs/reference/ebay/AddFixedPriceItem.html
    public class VerifyAddFixedPriceItemRequest : AllBase
    {
        public Item Item { get; set; }
    }
}
