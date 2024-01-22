using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("Pictures")]
    public class Pictures
    {
        [XmlElement("VariationSpecificName")]
        public string VariationSpecificName { get; set; }

        [XmlElement("VariationSpecificPictureSet")]
        public VariationSpecificPictureSet[] VariationSpecificPictureSet { get; set; }
    }
}
