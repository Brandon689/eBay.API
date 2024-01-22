using eBay.API.Models.Customer.Tax;
using System.Xml.Serialization;

namespace eBay.API.Models.Customer
{
    public class EBayCollectAndRemitTaxes
    {
        [XmlElement("TotalTaxAmount")]
        public AmountType TotalTaxAmount { get; set; }

        public TaxDetails TaxDetails { get; set; }

        public EBayReference EBayReference { get; set; }
    }
}
