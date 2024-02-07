using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ReturnsWithin")]
    public class ReturnsWithin
    {
        [XmlElement("ReturnsWithinOption")]
        public string ReturnsWithinOption { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
