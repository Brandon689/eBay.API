using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("TimeZoneDetails")]
    public class TimeZoneDetails
    {
        [XmlElement("TimeZoneID")]
        public string TimeZoneID { get; set; }

        [XmlElement("StandardLabel")]
        public string StandardLabel { get; set; }

        [XmlElement("StandardOffset")]
        public string StandardOffset { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("DaylightSavingsLabel")]
        public string DaylightSavingsLabel { get; set; }

        [XmlElement("DaylightSavingsOffset")]
        public string DaylightSavingsOffset { get; set; }

        [XmlElement("DaylightSavingsInEffect")]
        public bool DaylightSavingsInEffect { get; set; }
    }
}
