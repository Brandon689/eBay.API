using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ShippingLocationDetails")]
    public class ShippingLocationDetails
    {
        [XmlElement("ShippingLocation")]
        public string ShippingLocation { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
