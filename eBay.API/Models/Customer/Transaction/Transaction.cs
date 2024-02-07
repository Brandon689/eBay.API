using eBay.API.Models.Customer.Ship;
using eBay.API.Models.Customer.Tax;
using eBay.API.Models.Items;
using eBay.API.Models.Product.ProductVariations;
using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Transaction
{
    public class Transaction
    {
        public Buyer Buyer { get; set; }

        public ShippingDetails ShippingDetails { get; set; }

        public DateTime CreatedDate { get; set; }

        public Item Item { get; set; }

        public int QuantityPurchased { get; set; }

        public Status Status { get; set; }

        public double TransactionID { get; set; }

        [XmlElement("TransactionPrice")]
        public AmountType TransactionPrice { get; set; }

        public bool EBayCollectAndRemitTax { get; set; }

        public ShippingServiceSelected ShippingServiceSelected { get; set; }

        public DateTime ShippedTime { get; set; }

        [XmlElement("FinalValueFee")]
        public AmountType FinalValueFee { get; set; }

        public string TransactionSiteID { get; set; }

        public string Platform { get; set; }

        public Variation Variation { get; set; }

        public Taxes Taxes { get; set; }

        [XmlElement("ActualShippingCost")]
        public AmountType ActualShippingCost { get; set; }

        [XmlElement("ActualHandlingCost")]
        public AmountType ActualHandlingCost { get; set; }

        public string OrderLineItemID { get; set; }

        public double InventoryReservationID { get; set; }

        public string ExtendedOrderID { get; set; }

        public bool EBayPlusTransaction { get; set; }

        public bool GuaranteedShipping { get; set; }

        public bool GuaranteedDelivery { get; set; }

        public EBayCollectAndRemitTaxes EBayCollectAndRemitTaxes { get; set; }
    }
}
