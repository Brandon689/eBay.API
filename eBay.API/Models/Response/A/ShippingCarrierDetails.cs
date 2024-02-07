using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ShippingCarrierDetails")]
    public class ShippingCarrierDetails
    {
        [XmlElement("ShippingCarrierID")]
        public int ShippingCarrierID { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("ShippingCarrier")]
        public string ShippingCarrier { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
