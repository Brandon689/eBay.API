using eBay.API.Models.Generic;
using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Pay
{
    [XmlRoot("Payment")]
    public class Payment
    {
        [XmlElement("PaymentStatus")]
        public string PaymentStatus { get; set; }

        [XmlElement("Payer")]
        public UserIdentityType Payer { get; set; }

        [XmlElement("Payee")]
        public UserIdentityType Payee { get; set; }

        [XmlElement("PaymentTime")]
        public DateTime PaymentTime { get; set; }

        [XmlElement("PaymentAmount")]
        public AmountType PaymentAmount { get; set; }

        [XmlElement("ReferenceID")]
        public UserIdentityType ReferenceID { get; set; }

        [XmlElement("FeeOrCreditAmount")]
        public AmountType FeeOrCreditAmount { get; set; }
    }
}
