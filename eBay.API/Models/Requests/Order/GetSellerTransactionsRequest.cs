using eBay.API.Models.SellerStore;
using System.ComponentModel;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot("GetSellerTransactionsRequest")]
    public class GetSellerTransactionsRequest : GetBase
    {
        [DefaultValue(null)]
        [XmlElement("IncludeCodiceFiscale")]
        public bool? IncludeCodiceFiscale { get; set; }

        [DefaultValue(null)]
        [XmlElement("IncludeContainingOrder")]
        public bool? IncludeContainingOrder { get; set; }

        [DefaultValue(null)]
        [XmlElement("IncludeFinalValueFee")]
        public bool? IncludeFinalValueFee { get; set; }

        [XmlElement("InventoryTrackingMethod")]
        public string InventoryTrackingMethod { get; set; }

        [XmlElement("ModTimeFrom")]
        public string ModTimeFrom { get; set; }

        [XmlElement("ModTimeTo")]
        public string ModTimeTo { get; set; }

        [XmlElement("NumberOfDays")]
        public string NumberOfDays { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        [XmlElement("SKUArray")]
        public SKUArray SKUArray { get; set; }

        public bool ShouldSerializeIncludeCodiceFiscale() => IncludeCodiceFiscale != null;
        public bool ShouldSerializeIncludeContainingOrder() => IncludeContainingOrder != null;
        public bool ShouldSerializeIncludeFinalValueFee() => IncludeFinalValueFee != null;

    }
}
