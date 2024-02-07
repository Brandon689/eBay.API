using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("CountryDetails")]
    public class CountryDetails
    {
        [XmlElement("Country")]
        public string Country { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
