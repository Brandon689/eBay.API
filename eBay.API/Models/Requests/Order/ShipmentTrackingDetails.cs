using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    [XmlRoot("ShipmentTrackingDetails")]
    public class ShipmentTrackingDetails
    {
        [XmlElement("ShipmentLineItem")]
        public ShipmentLineItem ShipmentLineItem { get; set; }

        [XmlElement("ShipmentTrackingNumber")]
        public string ShipmentTrackingNumber { get; set; }

        [XmlElement("ShippingCarrierUsed")]
        public string ShippingCarrierUsed { get; set; }
    }
}
