using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{//https://developer.ebay.com/devzone/xml/docs/reference/ebay/AddFixedPriceItem.html
    public class AddFixedPriceItemRequest : AllBase
    {
        public RequesterCredentials RequesterCredentials { get; set; }

        public string ErrorLanguage { get; set; }

        public string WarningLevel { get; set; } = "High";

        public Item Item { get; set; }
    }
}
