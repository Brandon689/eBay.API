using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("ModifyNameList")]
    public class ModifyNameList
    {
        [XmlElement("ModifyName")]
        public ModifyName ModifyName { get; set; }
    }
}
