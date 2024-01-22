using eBay.API.Models.Customer.Pay;
using eBay.API.Models.Customer.Ship;
using eBay.API.Models.Items;
using eBay.API.Models.Product;
using eBay.API.Models.Product.ProductVariations;
using eBay.API.Models.SellerStore;
using System.ComponentModel;
using System.Xml.Serialization;

namespace eBay.API.Models
{
    public class Item
    {
        [DefaultValue(null)]
        public bool? AutoPay { get; set; } = null;

        public string BuyerProtection { get; set; }

        [XmlElement("BuyItNowPrice")]
        public AmountType BuyItNowPrice { get; set; }

        public string Country { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public string ItemID { get; set; }

        public ListingDetails ListingDetails { get; set; }

        public ListingDesigner ListingDesigner { get; set; }

        public string ListingDuration { get; set; }

        public string ListingType { get; set; }

        public string Location { get; set; }

        public PrimaryCategory PrimaryCategory { get; set; }

        [DefaultValue(null)]
        public bool? PrivateListing { get; set; } = null;

        public ProductListingDetails ProductListingDetails { get; set; }

        [DefaultValue(-1)]
        public int Quantity { get; set; } = -1;

        [DefaultValue(-1)]
        public int QuantityAvailable { get; set; } = -1;

        [DefaultValue(null)]
        public bool? IsItemEMSEligible { get; set; } = null;

        [XmlElement("ReservePrice")]
        public AmountType ReservePrice { get; set; }

        public ReviseStatus ReviseStatus { get; set; }

        public Seller Seller { get; set; }

        public SellingStatus SellingStatus { get; set; }

        public ShippingDetails ShippingDetails { get; set; }

        public string ShipToLocations { get; set; }

        public string Site { get; set; }

        [XmlElement("StartPrice")]
        public AmountType StartPrice { get; set; }

        public Storefront Storefront { get; set; }

        public string TimeLeft { get; set; }

        public string Title { get; set; }

        [DefaultValue(null)]
        public bool? GetItFast { get; set; } = null;

        public string SKU { get; set; }

        public PictureDetails PictureDetails { get; set; }

        [DefaultValue(0)]
        public int DispatchTimeMax { get; set; }

        [DefaultValue(null)]
        public bool? ProxyItem { get; set; } = null;

        [XmlElement("BuyerGuaranteePrice")]
        public AmountType BuyerGuaranteePrice { get; set; }

        public BuyerRequirementDetails BuyerRequirementDetails { get; set; }

        public ReturnPolicy ReturnPolicy { get; set; }

        [DefaultValue(0)]
        public int ConditionID { get; set; }

        public string ConditionDisplayName { get; set; }

        [DefaultValue(null)]
        public bool? PostCheckoutExperienceEnabled { get; set; } = null;

        public SellerProfiles SellerProfiles { get; set; }

        public ShippingPackageDetails ShippingPackageDetails { get; set; }

        [DefaultValue(null)]
        public bool? HideFromSearch { get; set; } = null;

        [DefaultValue(null)]
        public bool? OutOfStockControl { get; set; } = null;

        public PickupInStoreDetails PickupInStoreDetails { get; set; }

        [DefaultValue(null)]
        public bool? EBayPlus { get; set; } = null;

        [DefaultValue(null)]
        public bool? EBayPlusEligible { get; set; } = null;

        [DefaultValue(null)]
        public bool? IsSecureDescription { get; set; } = null;

        public PaymentDetails PaymentDetails { get; set; }

        public string HitCounter { get; set; }

        public string ListingEnhancement { get; set; }

        [XmlElement("PaymentMethods")]
        public string[] PaymentMethods { get; set; }

        public string SubTitle { get; set; }

        public string PostalCode { get; set; }

        public ItemSpecifics ItemSpecifics { get; set; }

        public string SellerProvidedTitle { get; set; }

        [XmlElement("Variations")]
        public Variations Variations { get; set; }

        public string VIN { get; set; }

        public bool ShouldSerializeIsSecureDescription() => IsSecureDescription != null;
        public bool ShouldSerializeEBayPlusEligible() => EBayPlusEligible != null;
        public bool ShouldSerializeEBayPlus() => EBayPlus != null;
        public bool ShouldSerializeOutOfStockControl() => OutOfStockControl != null;
        public bool ShouldSerializeHideFromSearch() => HideFromSearch != null;
        public bool ShouldSerializePostCheckoutExperienceEnabled() => PostCheckoutExperienceEnabled != null;
        public bool ShouldSerializeProxyItem() => ProxyItem != null;
        public bool ShouldSerializePrivateListing() => PrivateListing != null;
        public bool ShouldSerializeAutoPay() => AutoPay != null;
        public bool ShouldSerializeIsItemEMSEligible() => IsItemEMSEligible != null;
        public bool ShouldSerializeGetItFast() => GetItFast != null;
    }
}