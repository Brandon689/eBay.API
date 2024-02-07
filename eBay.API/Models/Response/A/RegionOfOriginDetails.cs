using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("RegionOfOriginDetails")]
    public class RegionOfOriginDetails
    {
        [XmlElement("RegionOfOrigin")]
        public string RegionOfOrigin { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Status")]
        public string Status { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
