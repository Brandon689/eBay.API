using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("Variations")]
    public class Variations
    {
        [XmlElement("Variation")]
        public Variation[] Variation { get; set; }

        [XmlElement("Pictures")]
        public Pictures Pictures { get; set; }

        [XmlElement("VariationSpecificsSet")]
        public VariationSpecificsSet VariationSpecificsSet { get; set; }
    }
}
