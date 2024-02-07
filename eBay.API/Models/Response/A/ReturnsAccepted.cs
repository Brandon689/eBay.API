using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ReturnsAccepted")]
    public class ReturnsAccepted
    {
        [XmlElement("ReturnsAcceptedOption")]
        public string ReturnsAcceptedOption { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
