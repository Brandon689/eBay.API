using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("NumberOfPolicyViolations")]
    public class NumberOfPolicyViolations
    {
        [XmlElement("Count")]
        public List<int> Count { get; set; }
    }
}
