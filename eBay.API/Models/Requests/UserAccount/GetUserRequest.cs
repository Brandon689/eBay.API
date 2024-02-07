using System.Xml.Serialization;

namespace eBay.API.Models.Requests.UserAccount
{
    [XmlRoot("GetUserRequest")]
    public class GetUserRequest : GetBase
    {
        [XmlElement("IncludeFeatureEligibility")]
        public bool IncludeFeatureEligibility { get; set; }

        [XmlElement("ItemID")]
        public string ItemID { get; set; }

        [XmlElement("UserID")]
        public string UserID { get; set; }
    }
}
