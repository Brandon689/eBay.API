using System.Xml.Serialization;

namespace eBay.API.Models.Customer
{
    [XmlRoot("OrderArray")]
    public class OrderArray
    {
        [XmlElement("Order")]
        public Order[] Order { get; set; }
    }
}
