using System.Xml.Serialization;

namespace eBay.API.Models.Product
{
    [XmlRoot("ProductListingDetails")]
    public class ProductListingDetails
    {
        [XmlElement("BrandMPN")]
        public BrandMPN BrandMPN { get; set; }
    }
}
