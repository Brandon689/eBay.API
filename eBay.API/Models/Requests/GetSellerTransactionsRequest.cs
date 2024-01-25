using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot("GetSellerTransactionsRequest")]
    public class GetSellerTransactionsRequest : GetBase
    {
        [XmlElement("IncludeCodiceFiscale")]
        public string IncludeCodiceFiscale { get; set; }

        [XmlElement("IncludeContainingOrder")]
        public string IncludeContainingOrder { get; set; }

        [XmlElement("IncludeFinalValueFee")]
        public string IncludeFinalValueFee { get; set; }

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

        [XmlElement("OutputSelector")]
        public string OutputSelector { get; set; }
    }
}
