using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("CurrencyDetails")]
    public class CurrencyDetails
    {
        [XmlElement("Currency")]
        public string Currency { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
