using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("SchedulingInfo")]
    public class SchedulingInfo
    {
        [XmlElement("MaxScheduledMinutes")]
        public int MaxScheduledMinutes { get; set; }

        [XmlElement("MinScheduledMinutes")]
        public int MinScheduledMinutes { get; set; }

        [XmlElement("MaxScheduledItems")]
        public int MaxScheduledItems { get; set; }
    }
}
