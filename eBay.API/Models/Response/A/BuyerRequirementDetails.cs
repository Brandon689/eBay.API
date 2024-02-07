using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("BuyerRequirementDetails")]
    public class BuyerRequirementDetails
    {
        [XmlElement("LinkedPayPalAccount")]
        public bool LinkedPayPalAccount { get; set; }

        [XmlElement("MaximumBuyerPolicyViolations")]
        public MaximumBuyerPolicyViolations MaximumBuyerPolicyViolations { get; set; }

        [XmlElement("MaximumItemRequirements")]
        public MaximumItemRequirements MaximumItemRequirements { get; set; }

        [XmlElement("MaximumUnpaidItemStrikesInfo")]
        public MaximumUnpaidItemStrikesInfo MaximumUnpaidItemStrikesInfo { get; set; }

        [XmlElement("MinimumFeedbackScore")]
        public MinimumFeedbackScore MinimumFeedbackScore { get; set; }

        [XmlElement("ShipToRegistrationCountry")]
        public bool ShipToRegistrationCountry { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
