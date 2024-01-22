using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("VariationSpecificPictureSet")]
    public class VariationSpecificPictureSet
    {
        [XmlElement("VariationSpecificValue")]
        public string VariationSpecificValue { get; set; }

        [XmlElement("PictureURL")]
        public string PictureURL { get; set; }
    }
}
