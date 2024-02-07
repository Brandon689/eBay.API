using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    public class GetBase
    {
        [XmlElement("RequesterCredentials")]
        public RequesterCredentials RequesterCredentials { get; set; }

        [XmlElement("DetailLevel")]
        public string DetailLevel { get; set; } = "ReturnAll";

        [XmlElement("Version")]
        public string Version { get; set; }

        [XmlElement("WarningLevel")]
        public string WarningLevel { get; set; }

        [XmlElement("ErrorLanguage")]
        public string ErrorLanguage { get; set; }

        [XmlElement("MessageID")]
        public string MessageID { get; set; }

        [XmlElement("OutputSelector")]
        public List<OutputSelector> OutputSelectors { get; set; } = new List<OutputSelector>();
    }
}
