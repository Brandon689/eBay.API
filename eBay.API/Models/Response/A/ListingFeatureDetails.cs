using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("ListingFeatureDetails")]
    public class ListingFeatureDetails
    {
        [XmlElement("BoldTitle")]
        public string BoldTitle { get; set; }

        [XmlElement("Border")]
        public string Border { get; set; }

        [XmlElement("Highlight")]
        public string Highlight { get; set; }

        [XmlElement("GiftIcon")]
        public string GiftIcon { get; set; }

        [XmlElement("HomePageFeatured")]
        public string HomePageFeatured { get; set; }

        [XmlElement("FeaturedFirst")]
        public string FeaturedFirst { get; set; }

        [XmlElement("FeaturedPlus")]
        public string FeaturedPlus { get; set; }

        [XmlElement("ProPack")]
        public string ProPack { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
