using eBay.API.Models.Product;
using eBay.API.Models.Response.Error;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot(ElementName = "VerifyAddFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VerifyAddFixedPriceItemResponse
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

        [XmlElement("Ack")]
        public string Ack { get; set; }

        [XmlElement("Build")]
        public string Build { get; set; }

        [XmlElement("CorrelationID")]
        public string CorrelationID { get; set; }

        [XmlElement("Errors")]
        public Errors Errors { get; set; }

        [XmlElement("HardExpirationWarning")]
        public string HardExpirationWarning { get; set; }

        [XmlElement("Message")]
        public string Message { get; set; }

        [XmlElement("Timestamp")]
        public string Timestamp { get; set; }

        [XmlElement("Version")]
        public string Version { get; set; }
    }
}
