using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("VariationSpecificsSet")]
    public class VariationSpecificsSet
    {
        [XmlElement("NameValueList")]
        public NameValueList[] NameValueList { get; set; }
    }
}
