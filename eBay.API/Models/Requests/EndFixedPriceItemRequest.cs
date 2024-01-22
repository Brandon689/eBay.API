using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot("EndFixedPriceItemRequest")]
    public class EndFixedPriceItemRequest
    {
        [XmlElement("RequesterCredentials")]
        public RequesterCredentials RequesterCredentials { get; set; }

        [XmlElement("ItemID")]
        public string ItemID { get; set; }

        [XmlElement("EndingReason")]
        public string EndingReason { get; set; }

        public string ErrorLanguage { get; set; }

        public string WarningLevel { get; set; } = "High";
    }
}
