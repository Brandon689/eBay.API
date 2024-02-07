using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("MaximumBuyerPolicyViolations")]
    public class MaximumBuyerPolicyViolations
    {
        [XmlElement("NumberOfPolicyViolations")]
        public NumberOfPolicyViolations NumberOfPolicyViolations { get; set; }

        [XmlElement("PolicyViolationDuration")]
        public List<PolicyViolationDuration> PolicyViolationDuration { get; set; }
    }
}
