using eBay.API.Models.Requests.Base;
using System.ComponentModel;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    [XmlRoot("CompleteSaleRequest")]
    public class CompleteSaleRequest : SaleBase
    {
        [XmlElement("FeedbackInfo")]
        public FeedbackInfo FeedbackInfo { get; set; }

        [XmlElement("ItemID")]
        public string ItemID { get; set; }

        [XmlElement("OrderID")]
        public string OrderID { get; set; }

        [XmlElement("OrderLineItemID")]
        public string OrderLineItemID { get; set; }

        [DefaultValue(null)]
        [XmlElement("Paid")]
        public bool? Paid { get; set; }

        [XmlElement("Shipment")]
        public Shipment Shipment { get; set; }

        [XmlElement("Shipped")]
        public bool? Shipped { get; set; }

        [XmlElement("TransactionID")]
        public string TransactionID { get; set; }

        public bool ShouldSerializePaid() => Paid != null;
        public bool ShouldSerializeShipped() => Shipped != null;
    }
}
