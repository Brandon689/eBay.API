using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot("SKUArray")]
    public class SKUArray
    {
        [XmlElement("SKU")]
        public string SKU { get; set; }
    }
}
