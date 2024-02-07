using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("MaximumUnpaidItemStrikesCount")]
    public class MaximumUnpaidItemStrikesCount
    {
        [XmlElement("Count")]
        public List<int> Count { get; set; }
    }
}
