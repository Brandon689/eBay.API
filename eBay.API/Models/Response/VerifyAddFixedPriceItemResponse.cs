using eBay.API.Models.Product;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("VerifyAddFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VerifyAddFixedPriceItemResponse : ResponseBase
    {
        [XmlElement("Category2ID")]
        public string Category2ID { get; set; }

        [XmlElement("CategoryID")]
        public string CategoryID { get; set; }

        [XmlElement("DiscountReason")]
        public string DiscountReason { get; set; }

        [XmlElement("Fees")]
        public Fees Fees { get; set; }

        [XmlElement("ItemID")]
        public string ItemID { get; set; }

        [XmlElement("SKU")]
        public string SKU { get; set; }

        [XmlElement("HardExpirationWarning")]
        public string HardExpirationWarning { get; set; }

        [XmlElement("Message")]
        public string Message { get; set; }
    }
}
