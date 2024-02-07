using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("URLDetails")]
    public class URLDetails
    {
        [XmlElement("URLType")]
        public string URLType { get; set; }

        [XmlElement("URL")]
        public string URL { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
