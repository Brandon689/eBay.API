using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("SiteDetails")]
    public class SiteDetails
    {
        [XmlElement("Site")]
        public string Site { get; set; }

        [XmlElement("SiteID")]
        public int SiteID { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
