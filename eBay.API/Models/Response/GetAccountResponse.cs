using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("AmountPastDue")]
    public class AmountPastDue
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("CurrentBalance")]
    public class CurrentBalance
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("InvoiceBalance")]
    public class InvoiceBalance
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("LastAmountPaid")]
    public class LastAmountPaid
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("TotalNettedChargeAmount")]
    public class TotalNettedChargeAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("TotalNettedCreditAmount")]
    public class TotalNettedCreditAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("NettedTransactionSummary")]
    public class NettedTransactionSummary
    {
        [XmlElement("TotalNettedChargeAmount")]
        public TotalNettedChargeAmount TotalNettedChargeAmount { get; set; }

        [XmlElement("TotalNettedCreditAmount")]
        public TotalNettedCreditAmount TotalNettedCreditAmount { get; set; }
    }

    [XmlRoot("AccountSummary")]
    public class AccountSummary
    {
        [XmlElement("AccountState")]
        public string AccountState { get; set; }

        [XmlElement("AmountPastDue")]
        public AmountPastDue AmountPastDue { get; set; }

        [XmlElement("BillingCycleDate")]
        public int BillingCycleDate { get; set; }

        [XmlElement("CurrentBalance")]
        public CurrentBalance CurrentBalance { get; set; }

        [XmlElement("InvoiceBalance")]
        public InvoiceBalance InvoiceBalance { get; set; }

        [XmlElement("InvoiceDate")]
        public DateTime InvoiceDate { get; set; }

        [XmlElement("LastAmountPaid")]
        public LastAmountPaid LastAmountPaid { get; set; }

        [XmlElement("LastPaymentDate")]
        public DateTime LastPaymentDate { get; set; }

        [XmlElement("PastDue")]
        public bool PastDue { get; set; }

        [XmlElement("PaymentMethod")]
        public string PaymentMethod { get; set; }

        [XmlElement("NettedTransactionSummary")]
        public NettedTransactionSummary NettedTransactionSummary { get; set; }
    }

    [XmlRoot("Balance")]
    public class Balance
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("GrossDetailAmount")]
    public class GrossDetailAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("NetDetailAmount")]
    public class NetDetailAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot("AccountEntry")]
    public class AccountEntry
    {
        [XmlElement("AccountDetailsEntryType")]
        public string AccountDetailsEntryType { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Balance")]
        public Balance Balance { get; set; }

        [XmlElement("Date")]
        public DateTime Date { get; set; }

        [XmlElement("GrossDetailAmount")]
        public GrossDetailAmount GrossDetailAmount { get; set; }

        [XmlElement("ItemID")]
        public double ItemID { get; set; }

        [XmlElement("NetDetailAmount")]
        public NetDetailAmount NetDetailAmount { get; set; }

        [XmlElement("RefNumber")]
        public double RefNumber { get; set; }

        [XmlElement("VATPercent")]
        public double VATPercent { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("Netted")]
        public bool Netted { get; set; }

        [XmlElement("Memo")]
        public string Memo { get; set; }

        [XmlElement("OrderId")]
        public string OrderId { get; set; }

        [XmlElement("OrderLineItemID")]
        public string OrderLineItemID { get; set; }

        [XmlElement("TransactionID")]
        public double TransactionID { get; set; }
    }

    [XmlRoot("AccountEntries")]
    public class AccountEntries
    {

        [XmlElement("AccountEntry")]
        public List<AccountEntry> AccountEntry { get; set; }
    }

    [XmlRoot("GetAccountResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetAccountResponse : ResponseBase
    {
        [XmlElement("AccountID")]
        public string AccountID { get; set; }

        [XmlElement("FeeNettingStatus")]
        public string FeeNettingStatus { get; set; }

        [XmlElement("AccountSummary")]
        public AccountSummary AccountSummary { get; set; }

        [XmlElement("Currency")]
        public string Currency { get; set; }

        [XmlElement("AccountEntries")]
        public AccountEntries AccountEntries { get; set; }

        [XmlElement("PaginationResult")]
        public PaginationResult PaginationResult { get; set; }

        [XmlElement("EntriesPerPage")]
        public int EntriesPerPage { get; set; }

        [XmlElement("PageNumber")]
        public int PageNumber { get; set; }
    }
}
