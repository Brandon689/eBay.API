using eBay.API.Models.Items;
using System.ComponentModel;
using System.Xml.Serialization;

namespace eBay.API.Models.Product.ProductVariations
{
    [XmlRoot("Variation")]
    public class Variation
    {
        [XmlElement("SKU")]
        public string SKU { get; set; }

        [XmlElement("StartPrice")]
        public AmountType StartPrice { get; set; }

        [XmlElement("Quantity")]
        public int Quantity { get; set; }

        public int UnitsAvailable { get; set; }

        [XmlElement("VariationSpecifics")]
        public VariationSpecifics VariationSpecifics { get; set; }

        [XmlElement("SellingStatus")]
        public SellingStatus SellingStatus { get; set; }

        [XmlElement("VariationProductListingDetails")]
        public VariationProductListingDetails VariationProductListingDetails { get; set; }

        public string PrivateNotes { get; set; }

        public string VariationTitle { get; set; }

        public string VariationViewItemURL { get; set; }

        public long WatchCount { get; set; }

        //public DiscountPriceInfo DiscountPriceInfo { get; set; }

        [DefaultValue(null)]
        public bool? Delete { get; set; }

        public bool ShouldSerializeDelete() => Delete != null;
    }
}
