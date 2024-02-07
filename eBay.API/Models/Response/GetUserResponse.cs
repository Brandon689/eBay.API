using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetUserResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetUserResponse : ResponseBase
    {
        [XmlElement("User")]
        public User User { get; set; }
    }
}
