using System.Xml.Serialization;

namespace eBay.API.Models.Generic
{
    [XmlRoot("UserIdentityType")]
    public class UserIdentityType
    {
        [XmlElement("Type")]
        public string Type { get; set; }

        [XmlElement("Text")]
        public string Text { get; set; }
    }
}
