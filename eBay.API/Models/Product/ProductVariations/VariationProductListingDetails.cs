using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("VariationProductListingDetails")]
    public class VariationProductListingDetails
    {
        [XmlElement("UPC")]
        public string UPC { get; set; }
    }
}
