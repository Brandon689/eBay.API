using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("StoreOwnerExtendedListingDurations")]
    public class StoreOwnerExtendedListingDurations
    {
        [XmlElement("Duration")]
        public List<string> Duration { get; set; }
    }
}
