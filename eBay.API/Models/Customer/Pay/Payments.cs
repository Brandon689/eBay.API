using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Pay
{
    [XmlRoot("Payments")]
    public class Payments
    {
        [XmlElement("Payment")]
        public Payment[] Payment { get; set; }
    }
}
