using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    public class GetOrdersRequest : GetBase
    {
        [XmlElement("CreateTimeFrom")]
        public string CreateTimeFrom { get; set; }

        [XmlElement("CreateTimeTo")]
        public string CreateTimeTo { get; set; }

        [XmlElement("IncludeFinalValueFee")]
        public bool IncludeFinalValueFee { get; set; }

        [XmlElement("ListingType")]
        public string ListingType { get; set; }

        [XmlElement("ModTimeFrom")]
        public string ModTimeFrom { get; set; }

        [XmlElement("ModTimeTo")]
        public string ModTimeTo { get; set; }

        [XmlElement("NumberOfDays")]
        public string NumberOfDays { get; set; }

        [XmlElement("OrderIDArray")]
        public OrderIDArray OrderIDArray { get; set; }

        [XmlElement("OrderRole")]
        public string OrderRole { get; set; }

        [XmlElement("OrderStatus")]
        public string OrderStatus { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        [XmlElement("SortingOrder")]
        public string SortingOrder { get; set; }
    }
}
