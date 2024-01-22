using eBay.API.Models.Product;
using eBay.API.Models.Response.Error;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot(ElementName = "VerifyAddFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VerifyAddFixedPriceItemResponse
    {
        [XmlElement(ElementName = "Category2ID")]
        public string Category2ID { get; set; }

        [XmlElement(ElementName = "CategoryID")]
        public string CategoryID { get; set; }

        [XmlElement(ElementName = "DiscountReason")]
        public string DiscountReason { get; set; }

        [XmlElement(ElementName = "Fees")]
        public Fees Fees { get; set; }

        [XmlElement(ElementName = "ItemID")]
        public string ItemID { get; set; }

        [XmlElement(ElementName = "SKU")]
        public string SKU { get; set; }

        [XmlElement(ElementName = "Ack")]
        public string Ack { get; set; }

        [XmlElement(ElementName = "Build")]
        public string Build { get; set; }

        [XmlElement(ElementName = "CorrelationID")]
        public string CorrelationID { get; set; }

        [XmlElement(ElementName = "Errors")]
        public Errors Errors { get; set; }

        [XmlElement(ElementName = "HardExpirationWarning")]
        public string HardExpirationWarning { get; set; }

        [XmlElement(ElementName = "Message")]
        public string Message { get; set; }

        [XmlElement(ElementName = "Timestamp")]
        public string Timestamp { get; set; }

        [XmlElement(ElementName = "Version")]
        public string Version { get; set; }
    }
}
