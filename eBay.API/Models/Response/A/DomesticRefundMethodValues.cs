using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("DomesticRefundMethodValues")]
    public class DomesticRefundMethodValues
    {
        [XmlElement("DomesticRefundMethod")]
        public string DomesticRefundMethod { get; set; }
    }
}
