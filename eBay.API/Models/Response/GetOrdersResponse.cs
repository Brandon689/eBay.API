using eBay.API.Models.Customer;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetOrdersResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetOrdersResponse
    {
        [XmlElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement("Ack")]
        public string Ack { get; set; }

        [XmlElement("Version")]
        public int Version { get; set; }

        [XmlElement("Build")]
        public string Build { get; set; }

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
