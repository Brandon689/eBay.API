using System.Xml.Serialization;

namespace eBay.API.Models.Product
{
    [XmlRoot("Fees")]
    public class Fees
    {
        [XmlElement("Fee")]
        public Fee[] Fee { get; set; }
    }
}
