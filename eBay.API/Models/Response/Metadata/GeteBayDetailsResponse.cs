using eBay.API.Models.Response.NewFolder;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GeteBayDetailsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GeteBayDetailsResponse
    {
        [XmlElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement("Ack")]
        public string Ack { get; set; }

        [XmlElement("Version")]
        public int Version { get; set; }

        [XmlElement("Build")]
        public string Build { get; set; }

        [XmlElement("CountryDetails")]
        public List<CountryDetails> CountryDetails { get; set; }

        [XmlElement("CurrencyDetails")]
        public List<CurrencyDetails> CurrencyDetails { get; set; }

        [XmlElement("DispatchTimeMaxDetails")]
        public List<DispatchTimeMaxDetails> DispatchTimeMaxDetails { get; set; }

        [XmlElement("PaymentOptionDetails")]
        public List<PaymentOptionDetails> PaymentOptionDetails { get; set; }

        [XmlElement("RegionDetails")]
        public List<RegionDetails> RegionDetails { get; set; }

        [XmlElement("ShippingLocationDetails")]
        public List<ShippingLocationDetails> ShippingLocationDetails { get; set; }

        [XmlElement("ShippingServiceDetails")]
        public List<ShippingServiceDetails> ShippingServiceDetails { get; set; }

        [XmlElement("SiteDetails")]
        public List<SiteDetails> SiteDetails { get; set; }

        [XmlElement("URLDetails")]
        public List<URLDetails> URLDetails { get; set; }

        [XmlElement("TimeZoneDetails")]
        public List<TimeZoneDetails> TimeZoneDetails { get; set; }

        [XmlElement("ItemSpecificDetails")]
        public ItemSpecificDetails ItemSpecificDetails { get; set; }

        [XmlElement("RegionOfOriginDetails")]
        public List<RegionOfOriginDetails> RegionOfOriginDetails { get; set; }

        [XmlElement("ShippingPackageDetails")]
        public List<ShippingPackageDetails> ShippingPackageDetails { get; set; }

        [XmlElement("ShippingCarrierDetails")]
        public List<ShippingCarrierDetails> ShippingCarrierDetails { get; set; }

        [XmlElement("ReturnPolicyDetails")]
        public ReturnPolicyDetails ReturnPolicyDetails { get; set; }

        [XmlElement("ListingStartPriceDetails")]
        public List<ListingStartPriceDetails> ListingStartPriceDetails { get; set; }

        [XmlElement("BuyerRequirementDetails")]
        public BuyerRequirementDetails BuyerRequirementDetails { get; set; }

        [XmlElement("ListingFeatureDetails")]
        public ListingFeatureDetails ListingFeatureDetails { get; set; }

        [XmlElement("VariationDetails")]
        public VariationDetails VariationDetails { get; set; }

        [XmlElement("ExcludeShippingLocationDetails")]
        public List<ExcludeShippingLocationDetails> ExcludeShippingLocationDetails { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("RecoupmentPolicyDetails")]
        public RecoupmentPolicyDetails RecoupmentPolicyDetails { get; set; }

        [XmlElement("ShippingCategoryDetails")]
        public List<ShippingCategoryDetails> ShippingCategoryDetails { get; set; }

        [XmlElement("ProductDetails")]
        public ProductDetails ProductDetails { get; set; }
    }
}
