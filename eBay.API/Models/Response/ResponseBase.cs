using eBay.API.Models.Response.Error;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    public class ResponseBase
    {
        [XmlElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement("Ack")]
        public string Ack { get; set; }

        [XmlElement("Errors")]
        public Errors Errors { get; set; }

        [XmlElement("Version")]
        public int Version { get; set; }

        [XmlElement("Build")]
        public string Build { get; set; }

        [XmlElement("CorrelationID")]
        public string CorrelationID { get; set; }
    }
}
