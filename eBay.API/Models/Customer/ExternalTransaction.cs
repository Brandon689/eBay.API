using System.Xml.Serialization;

namespace eBay.API.Models.Customer
{
    [XmlRoot("ExternalTransaction")]
    public class ExternalTransaction
    {
        [XmlElement("ExternalTransactionID")]
        public double ExternalTransactionID { get; set; }

        [XmlElement("ExternalTransactionTime")]
        public DateTime ExternalTransactionTime { get; set; }

        [XmlElement("FeeOrCreditAmount")]
        public AmountType FeeOrCreditAmount { get; set; }

        [XmlElement("PaymentOrRefundAmount")]
        public AmountType PaymentOrRefundAmount { get; set; }

        [XmlElement("ExternalTransactionStatus")]
        public string ExternalTransactionStatus { get; set; }
    }
}
