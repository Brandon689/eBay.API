using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    [XmlRoot("OrderIDArray")]
    public class OrderIDArray
    {

        [XmlElement("OrderID")]
        public string OrderID { get; set; }
    }
}
