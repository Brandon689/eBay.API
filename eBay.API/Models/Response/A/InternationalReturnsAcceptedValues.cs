using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("InternationalReturnsAcceptedValues")]
    public class InternationalReturnsAcceptedValues
    {
        [XmlElement("InternationalReturnsAccepted")]
        public List<string> InternationalReturnsAccepted { get; set; }
    }
}
