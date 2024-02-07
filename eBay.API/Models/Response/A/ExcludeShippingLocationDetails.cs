using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("ExcludeShippingLocationDetails")]
    public class ExcludeShippingLocationDetails
    {
        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Location")]
        public string Location { get; set; }

        [XmlElement("Region")]
        public string Region { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
