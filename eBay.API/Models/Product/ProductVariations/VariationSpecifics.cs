using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("VariationSpecifics")]
    public class VariationSpecifics
    {
        [XmlElement("NameValueList")]
        public NameValueList[] NameValueList { get; set; }
    }
}