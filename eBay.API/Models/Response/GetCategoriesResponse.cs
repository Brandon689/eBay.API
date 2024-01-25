using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot(ElementName = "GetCategoriesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetCategoriesResponse
    {
        [XmlElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement("Ack")]
        public string Ack { get; set; }

        [XmlElement("Version")]
        public int Version { get; set; }

        [XmlElement("Build")]
        public string Build { get; set; }

        [XmlElement("CategoryArray")]
        public CategoryArray CategoryArray { get; set; }

        [XmlElement("CategoryCount")]
        public int CategoryCount { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("CategoryVersion")]
        public int CategoryVersion { get; set; }

        [XmlElement("MinimumReservePrice")]
        public double MinimumReservePrice { get; set; }
    }
}
