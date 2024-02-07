using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("PaymentOptionDetails")]
    public class PaymentOptionDetails
    {
        [XmlElement("PaymentOption")]
        public string PaymentOption { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
