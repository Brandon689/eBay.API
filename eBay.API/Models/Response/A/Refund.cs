using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("Refund")]
    public class Refund
    {
        [XmlElement("RefundOption")]
        public string RefundOption { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
