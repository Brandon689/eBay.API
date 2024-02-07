using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("InternationalReturnsDurationValues")]
    public class InternationalReturnsDurationValues
    {
        [XmlElement("InternationalReturnsDuration")]
        public List<string> InternationalReturnsDuration { get; set; }
    }
}
