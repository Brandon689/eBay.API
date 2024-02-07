using eBay.API.Models.Customer;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetOrdersResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetOrdersResponse : ResponseBase
    {
        [XmlElement("PaginationResult")]
        public PaginationResult PaginationResult { get; set; }

        [XmlElement("HasMoreOrders")]
        public bool HasMoreOrders { get; set; }

        [XmlElement("OrderArray")]
        public OrderArray OrderArray { get; set; }

        [XmlElement("OrdersPerPage")]
        public int OrdersPerPage { get; set; }

        [XmlElement("PageNumber")]
        public int PageNumber { get; set; }

        [XmlElement("ReturnedOrderCountActual")]
        public int ReturnedOrderCountActual { get; set; }
    }
}
