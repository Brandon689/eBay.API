using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("PolicyViolationDuration")]
    public class PolicyViolationDuration
    {
        [XmlElement("Period")]
        public string Period { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
