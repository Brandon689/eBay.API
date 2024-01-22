using eBay.API.Models.Customer.Pay;
using eBay.API.Models.Customer.Ship;
using eBay.API.Models.Customer.Transaction;
using System.Xml.Serialization;

namespace eBay.API.Models.Customer
{
    [XmlRoot("Order")]
    public class Order
    {
        [XmlElement("ExternalTransaction")]
        public ExternalTransaction[] ExternalTransaction { get; set; }

        [XmlElement("eBayCollectAndRemitTax")]
        public bool EBayCollectAndRemitTax { get; set; }

        [XmlElement("TransactionArray")]
        public TransactionArray TransactionArray { get; set; }

        [XmlElement("BuyerUserID")]
        public string BuyerUserID { get; set; }

        [XmlElement("PaidTime")]
        public DateTime PaidTime { get; set; }

        [XmlElement("IntegratedMerchantCreditCardEnabled")]
        public bool IntegratedMerchantCreditCardEnabled { get; set; }

        [XmlElement("EIASToken")]
        public string EIASToken { get; set; }

        [XmlElement("PaymentHoldStatus")]
        public string PaymentHoldStatus { get; set; }

        [XmlElement("IsMultiLegShipping")]
        public bool IsMultiLegShipping { get; set; }

        [XmlElement("MonetaryDetails")]
        public MonetaryDetails MonetaryDetails { get; set; }

        [XmlElement("SellerUserID")]
        public string SellerUserID { get; set; }

        [XmlElement("SellerEIASToken")]
        public string SellerEIASToken { get; set; }

        [XmlElement("CancelReason")]
        public string CancelReason { get; set; }

        [XmlElement("CancelStatus")]
        public string CancelStatus { get; set; }

        [XmlElement("ExtendedOrderID")]
        public string ExtendedOrderID { get; set; }

        [XmlElement("ContainseBayPlusTransaction")]
        public bool ContainseBayPlusTransaction { get; set; }

        [XmlElement("OrderID")]
        public string OrderID { get; set; }

        [XmlElement("OrderStatus")]
        public string OrderStatus { get; set; }

        [XmlElement("AdjustmentAmount")]
        public AmountType AdjustmentAmount { get; set; }

        [XmlElement("AmountPaid")]
        public AmountType AmountPaid { get; set; }

        [XmlElement("AmountSaved")]
        public AmountType AmountSaved { get; set; }

        [XmlElement("CheckoutStatus")]
        public CheckoutStatus CheckoutStatus { get; set; }

        [XmlElement("ShippingDetails")]
        public ShippingDetails ShippingDetails { get; set; }

        [XmlElement("CreatedTime")]
        public DateTime CreatedTime { get; set; }

        [XmlElement("ShippingAddress")]
        public ShippingAddress ShippingAddress { get; set; }

        [XmlElement("ShippingServiceSelected")]
        public ShippingServiceSelected ShippingServiceSelected { get; set; }

        [XmlElement("Subtotal")]
        public AmountType Subtotal { get; set; }

        [XmlElement("Total")]
        public AmountType Total { get; set; }

        [XmlElement("ShippedTime")]
        public DateTime ShippedTime { get; set; }

        [XmlElement("PaymentHoldDetails")]
        public PaymentHoldDetails PaymentHoldDetails { get; set; }
    }
}
