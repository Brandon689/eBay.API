using System.Xml.Serialization;

namespace eBay.API.Models.Product
{
    public class NameValueList
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Value")]
        public string[] Value { get; set; }
    }
}
