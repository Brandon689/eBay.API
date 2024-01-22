using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Pay
{
    public class PaymentDetails
    {
        public int DaysToFullPayment { get; set; }

        [XmlElement("DepositAmount")]
        public AmountType DepositAmount { get; set; }

        public string DepositType { get; set; }

        public int HoursToDeposit { get; set; }
    }
}
