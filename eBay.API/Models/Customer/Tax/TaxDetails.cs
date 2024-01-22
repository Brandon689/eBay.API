using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Tax
{
    public class TaxDetails
    {
        public string Imposition { get; set; }

        public string TaxDescription { get; set; }

        [XmlElement("TaxAmount")]
        public AmountType TaxAmount { get; set; }

        [XmlElement("TaxOnSubtotalAmount")]
        public AmountType TaxOnSubtotalAmount { get; set; }

        [XmlElement("TaxOnShippingAmount")]
        public AmountType TaxOnShippingAmount { get; set; }

        [XmlElement("TaxOnHandlingAmount")]
        public AmountType TaxOnHandlingAmount { get; set; }

        public string CollectionMethod { get; set; }
    }
}
