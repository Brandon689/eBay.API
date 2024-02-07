using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Base
{
    public class AllBase
    {
        [XmlElement("RequesterCredentials")]
        public RequesterCredentials RequesterCredentials { get; set; }

        [XmlElement("ErrorLanguage")]
        public string ErrorLanguage { get; set; }

        [XmlElement("MessageID")]
        public string MessageID { get; set; }

        [XmlElement("Version")]
        public string Version { get; set; }

        [XmlElement("WarningLevel")]
        public string WarningLevel { get; set; }
    }
}
