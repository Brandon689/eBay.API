using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    [XmlRoot("ShipmentLineItem")]
    public class ShipmentLineItem
    {
        [XmlElement("LineItem")]
        public LineItem LineItem { get; set; }
    }
}
