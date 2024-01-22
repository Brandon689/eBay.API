using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("ModifyName")]
    public class ModifyName
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("NewName")]
        public string NewName { get; set; }
    }
}
