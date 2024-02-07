using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("DeprecationDetails")]
    public class DeprecationDetails
    {
        [XmlElement("AnnouncementStartTime")]
        public DateTime AnnouncementStartTime { get; set; }

        [XmlElement("EventTime")]
        public DateTime EventTime { get; set; }

        [XmlElement("MessageType")]
        public string MessageType { get; set; }
    }
}
