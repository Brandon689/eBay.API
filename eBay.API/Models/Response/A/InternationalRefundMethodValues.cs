using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("InternationalRefundMethodValues")]
    public class InternationalRefundMethodValues
    {
        [XmlElement("InternationalRefundMethod")]
        public string InternationalRefundMethod { get; set; }
    }
}
