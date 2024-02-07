using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("RestockingFeeValue")]
    public class RestockingFeeValue
    {
        [XmlElement("RestockingFeeValueOption")]
        public string RestockingFeeValueOption { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
