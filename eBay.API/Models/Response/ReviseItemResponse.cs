using eBay.API.Models.Product;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ReviseItemResponse")]
    public class ReviseItemResponse : ResponseBase
    {
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
    }
}
