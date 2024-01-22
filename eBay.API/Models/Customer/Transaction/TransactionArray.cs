using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Transaction
{
    [XmlRoot("TransactionArray")]
    public class TransactionArray
    {
        [XmlElement("Transaction")]
        public Transaction[] Transaction { get; set; }
    }
}
