using eBay.API.Models.Response.NewFolder;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("MaximumUnpaidItemStrikesInfo")]
    public class MaximumUnpaidItemStrikesInfo
    {
        [XmlElement("MaximumUnpaidItemStrikesCount")]
        public MaximumUnpaidItemStrikesCount MaximumUnpaidItemStrikesCount { get; set; }

        [XmlElement("MaximumUnpaidItemStrikesDuration")]
        public List<MaximumUnpaidItemStrikesDuration> MaximumUnpaidItemStrikesDuration { get; set; }
    }
}
