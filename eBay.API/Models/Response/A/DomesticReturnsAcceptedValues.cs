using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("DomesticReturnsAcceptedValues")]
    public class DomesticReturnsAcceptedValues
    {
        [XmlElement("DomesticReturnsAccepted")]
        public List<string> DomesticReturnsAccepted { get; set; }
    }
}
