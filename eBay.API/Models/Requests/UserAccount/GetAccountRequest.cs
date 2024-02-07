using eBay.API.Models.SellerStore;
using System.ComponentModel;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests.UserAccount
{
    [XmlRoot("GetAccountRequest")]
    public class GetAccountRequest : GetBase
    {
        [XmlElement("AccountEntrySortType")]
        public string AccountEntrySortType { get; set; }

        [XmlElement("AccountHistorySelection")]
        public string AccountHistorySelection { get; set; }

        [XmlElement("BeginDate")]
        public string BeginDate { get; set; }

        [XmlElement("Currency")]
        public string Currency { get; set; }

        [XmlElement("EndDate")]
        public string EndDate { get; set; }

        [DefaultValue(null)]
        [XmlElement("ExcludeBalance")]
        public bool? ExcludeBalance { get; set; }

        [DefaultValue(null)]
        [XmlElement("ExcludeSummary")]
        public bool? ExcludeSummary { get; set; }

        [DefaultValue(null)]
        [XmlElement("IncludeConversionRate")]
        public bool? IncludeConversionRate { get; set; }

        [DefaultValue(null)]
        [XmlElement("IncludeNettedEntries")]
        public bool? IncludeNettedEntries { get; set; }

        [XmlElement("ItemID")]
        public string ItemID { get; set; }

        [XmlElement("OrderID")]
        public string OrderID { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        public bool ShouldSerializeExcludeBalance() => ExcludeBalance != null;
        public bool ShouldSerializeExcludeSummary() => ExcludeSummary != null;
        public bool ShouldSerializeIncludeConversionRate() => IncludeConversionRate != null;
        public bool ShouldSerializeIncludeNettedEntries() => IncludeNettedEntries != null;
    }
}
