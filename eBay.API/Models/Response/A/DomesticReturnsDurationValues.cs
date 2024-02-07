using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("DomesticReturnsDurationValues")]
    public class DomesticReturnsDurationValues
    {
        [XmlElement("DomesticReturnsDuration")]
        public List<string> DomesticReturnsDuration { get; set; }
    }
}
