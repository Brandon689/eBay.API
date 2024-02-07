using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models
{
    public class ItemListCustomizationType
    {
        [XmlElement("DurationInDays")]
        public int DurationInDays { get; set; }

        [XmlElement("Include")]
        public bool Include { get; set; }

        [XmlElement("IncludeNotes")]
        public bool IncludeNotes { get; set; }

        [XmlElement("OrderStatusFilter")]
        public string OrderStatusFilter { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        [XmlElement("Sort")]
        public string Sort { get; set; }
    }
}
