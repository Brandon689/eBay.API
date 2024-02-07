using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("DomesticReturnsShipmentPayeeValues")]
    public class DomesticReturnsShipmentPayeeValues
    {
        [XmlElement("DomesticReturnsShipmentPayee")]
        public List<string> DomesticReturnsShipmentPayee { get; set; }
    }
}
