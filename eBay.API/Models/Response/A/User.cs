using eBay.API.Models.Response.A;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("User")]
    public class User
    {
        [XmlElement("AboutMePage")]
        public bool AboutMePage { get; set; }

        [XmlElement("EIASToken")]
        public string EIASToken { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }

        [XmlElement("FeedbackScore")]
        public int FeedbackScore { get; set; }

        [XmlElement("UniqueNegativeFeedbackCount")]
        public int UniqueNegativeFeedbackCount { get; set; }

        [XmlElement("UniquePositiveFeedbackCount")]
        public int UniquePositiveFeedbackCount { get; set; }

        [XmlElement("PositiveFeedbackPercent")]
        public double PositiveFeedbackPercent { get; set; }

        [XmlElement("FeedbackPrivate")]
        public bool FeedbackPrivate { get; set; }

        [XmlElement("IDVerified")]
        public bool IDVerified { get; set; }

        [XmlElement("eBayGoodStanding")]
        public bool EBayGoodStanding { get; set; }

        [XmlElement("NewUser")]
        public bool NewUser { get; set; }

        [XmlElement("RegistrationAddress")]
        public RegistrationAddress RegistrationAddress { get; set; }

        [XmlElement("RegistrationDate")]
        public DateTime RegistrationDate { get; set; }

        [XmlElement("Site")]
        public string Site { get; set; }

        [XmlElement("Status")]
        public string Status { get; set; }

        [XmlElement("UserID")]
        public string UserID { get; set; }

        [XmlElement("UserIDChanged")]
        public bool UserIDChanged { get; set; }

        [XmlElement("UserIDLastChanged")]
        public DateTime UserIDLastChanged { get; set; }

        [XmlElement("VATStatus")]
        public string VATStatus { get; set; }

        [XmlElement("SellerInfo")]
        public SellerInfo SellerInfo { get; set; }

        [XmlElement("BusinessRole")]
        public string BusinessRole { get; set; }

        [XmlElement("EBaySubscription")]
        public string EBaySubscription { get; set; }

        [XmlElement("UserSubscription")]
        public string UserSubscription { get; set; }

        [XmlElement("eBayWikiReadOnly")]
        public bool EBayWikiReadOnly { get; set; }

        [XmlElement("MotorsDealer")]
        public bool MotorsDealer { get; set; }

        [XmlElement("UniqueNeutralFeedbackCount")]
        public int UniqueNeutralFeedbackCount { get; set; }

        [XmlElement("EnterpriseSeller")]
        public bool EnterpriseSeller { get; set; }
    }
}
