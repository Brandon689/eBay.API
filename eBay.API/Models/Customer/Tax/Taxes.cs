using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Tax
{
    public class Taxes
    {
        [XmlElement("TotalTaxAmount")]
        public AmountType TotalTaxAmount { get; set; }

        public TaxDetails TaxDetails { get; set; }
    }
}
