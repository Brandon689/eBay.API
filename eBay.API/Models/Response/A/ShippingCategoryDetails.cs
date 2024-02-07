using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ShippingCategoryDetails")]
    public class ShippingCategoryDetails
    {
        [XmlElement("ShippingCategory")]
        public string ShippingCategory { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
