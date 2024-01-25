using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot(ElementName = "GetCategoriesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetCategoriesResponse
    {
        [XmlElement(ElementName = "Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement(ElementName = "Ack")]
        public string Ack { get; set; }

        [XmlElement(ElementName = "Version")]
        public int Version { get; set; }

        [XmlElement(ElementName = "Build")]
        public string Build { get; set; }

        [XmlElement(ElementName = "CategoryArray")]
        public CategoryArray CategoryArray { get; set; }

        [XmlElement(ElementName = "CategoryCount")]
        public int CategoryCount { get; set; }

        [XmlElement(ElementName = "UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement(ElementName = "CategoryVersion")]
        public int CategoryVersion { get; set; }

        [XmlElement(ElementName = "MinimumReservePrice")]
        public double MinimumReservePrice { get; set; }
    }
}
