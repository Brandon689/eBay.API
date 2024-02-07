using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("RecoupmentPolicyDetails")]
    public class RecoupmentPolicyDetails
    {
        [XmlElement("EnforcedOnListingSite")]
        public bool EnforcedOnListingSite { get; set; }

        [XmlElement("EnforcedOnRegistrationSite")]
        public bool EnforcedOnRegistrationSite { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
