using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    public class GetItemRequest : GetBase
    {
        public string ItemID { get; set; }
    }
}
