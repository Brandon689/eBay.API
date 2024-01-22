using System.Xml.Serialization;

namespace eBay.API.Models.Product
{
    [XmlRoot("Fee")]
    public class Fee
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Fee")]
        public AmountType FeeAmount { get; set; }

        [XmlElement("PromotionalDiscount")]
        public AmountType PromotionalDiscount { get; set; }
    }
}
