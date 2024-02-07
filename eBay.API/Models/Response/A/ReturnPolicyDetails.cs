using eBay.API.Models.Response.NewFolder;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ReturnPolicyDetails")]
    public class ReturnPolicyDetails
    {
        [XmlElement("Refund")]
        public List<Refund> Refund { get; set; }

        [XmlElement("ReturnsWithin")]
        public List<ReturnsWithin> ReturnsWithin { get; set; }

        [XmlElement("ReturnsAccepted")]
        public List<ReturnsAccepted> ReturnsAccepted { get; set; }

        [XmlElement("Description")]
        public bool Description { get; set; }

        [XmlElement("ShippingCostPaidBy")]
        public List<ShippingCostPaidBy> ShippingCostPaidBy { get; set; }

        [XmlElement("RestockingFeeValue")]
        public List<RestockingFeeValue> RestockingFeeValue { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
