using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("DispatchTimeMaxDetails")]
    public class DispatchTimeMaxDetails
    {
        [XmlElement("DispatchTimeMax")]
        public int DispatchTimeMax { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("ExtendedHandling")]
        public bool ExtendedHandling { get; set; }
    }
}
