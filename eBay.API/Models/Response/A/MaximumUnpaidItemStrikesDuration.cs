using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("MaximumUnpaidItemStrikesDuration")]
    public class MaximumUnpaidItemStrikesDuration
    {
        [XmlElement("Period")]
        public string Period { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
