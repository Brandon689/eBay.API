using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("InternationalReturnsShipmentPayeeValues")]
    public class InternationalReturnsShipmentPayeeValues
    {
        [XmlElement("InternationalReturnsShipmentPayee")]
        public List<string> InternationalReturnsShipmentPayee { get; set; }
    }
}
