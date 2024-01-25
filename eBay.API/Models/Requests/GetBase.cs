using eBay.API.Models.SellerStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    public class GetBase
    {
        public RequesterCredentials RequesterCredentials { get; set; }

        [XmlElement(ElementName = "DetailLevel")]
        public string DetailLevel { get; set; } = "ReturnAll";

        [XmlElement(ElementName = "Version")]
        public string Version { get; set; }

        [XmlElement(ElementName = "WarningLevel")]
        public string WarningLevel { get; set; }

        [XmlElement(ElementName = "ErrorLanguage")]
        public string ErrorLanguage { get; set; }

        [XmlElement(ElementName = "MessageID")]
        public string MessageID { get; set; }

        [XmlElement("OutputSelector")]
        public List<OutputSelector> OutputSelectors { get; set; } = new List<OutputSelector>();
    }
}
