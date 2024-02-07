using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    [XmlRoot("Shipment")]
    public class Shipment
    {
        [XmlElement("ShipmentTrackingDetails")]
        public ShipmentTrackingDetails ShipmentTrackingDetails { get; set; }

        [XmlElement("ShippedTime")]
        public string ShippedTime { get; set; }
    }
}
