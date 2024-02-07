using eBay.API.Models.Generic;
using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Refund
{
    public class Refund
    {
        public string RefundStatus { get; set; }

        public string RefundType { get; set; }

        [XmlElement("RefundTo")]
        public UserIdentityType RefundTo { get; set; }

        public DateTime RefundTime { get; set; }

        [XmlElement("RefundAmount")]
        public AmountType RefundAmount { get; set; }

        [XmlElement("ReferenceID")]
        public UserIdentityType ReferenceID { get; set; }

        [XmlElement("FeeOrCreditAmount")]
        public AmountType FeeOrCreditAmount { get; set; }
    }
}
