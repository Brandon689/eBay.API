using eBay.API.Models.Customer.Transaction;
using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetSellerTransactionsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetSellerTransactionsResponse : ResponseBase
    {
        [XmlElement("PaginationResult")]
        public PaginationResult PaginationResult { get; set; }

        [XmlElement("HasMoreTransactions")]
        public bool HasMoreTransactions { get; set; }

        [XmlElement("TransactionsPerPage")]
        public int TransactionsPerPage { get; set; }

        [XmlElement("PageNumber")]
        public int PageNumber { get; set; }

        [XmlElement("ReturnedTransactionCountActual")]
        public int ReturnedTransactionCountActual { get; set; }

        [XmlElement("Seller")]
        public Seller Seller { get; set; }

        [XmlElement("TransactionArray")]
        public TransactionArray TransactionArray { get; set; }

        [XmlElement("PayPalPreferred")]
        public bool PayPalPreferred { get; set; }
    }
}
