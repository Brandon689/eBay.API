using System.Xml.Serialization;

namespace eBay.API.Models.Product
{
    [XmlRoot("BrandMPN")]
    public class BrandMPN
    {
        [XmlElement("Brand")]
        public string Brand { get; set; }

        [XmlElement("MPN")]
        public string MPN { get; set; }
    }
}
