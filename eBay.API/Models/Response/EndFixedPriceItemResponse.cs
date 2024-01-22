using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("EndFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class EndFixedPriceItemResponse
    {
        [XmlElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement("Ack")]
        public string Ack { get; set; }

        [XmlElement("Version")]
        public int Version { get; set; }

        [XmlElement("Build")]
        public string Build { get; set; }

        [XmlElement("EndTime")]
        public DateTime EndTime { get; set; }
    }
}
