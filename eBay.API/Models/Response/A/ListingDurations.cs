using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("ListingDurations")]
    public class ListingDurations
    {
        [XmlAttribute(AttributeName = "Version")]
        public int Version { get; set; }
    }
}
