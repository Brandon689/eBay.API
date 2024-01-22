using eBay.API.Models.Product;
using eBay.API.Models.Response.Error;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ReviseItemResponse")]
    public class ReviseItemResponse
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

        [XmlElement("ItemID")]
        public double ItemID { get; set; }

        [XmlElement("StartTime")]
        public DateTime StartTime { get; set; }

        [XmlElement("EndTime")]
        public DateTime EndTime { get; set; }

        [XmlElement("Fees")]
        public Fees Fees { get; set; }

        [XmlElement("DiscountReason")]
        public string DiscountReason { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
