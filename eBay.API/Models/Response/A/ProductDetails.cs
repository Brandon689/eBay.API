using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ProductDetails")]
    public class ProductDetails
    {
        [XmlElement("ProductIdentifierUnavailableText")]
        public string ProductIdentifierUnavailableText { get; set; }
    }
}
