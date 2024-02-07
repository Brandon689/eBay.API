using eBay.API.Models.Requests.Base;

namespace eBay.API.Models.Requests.Metadata
{//https://developer.ebay.com/devzone/xml/docs/reference/ebay/GeteBayOfficialTime.html
    public class GeteBayDetailsRequest : AllBase
    {
        public string DetailName { get; set; }
    }
}
