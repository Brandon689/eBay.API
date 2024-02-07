using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("ListingStartPriceDetails")]
    public class ListingStartPriceDetails
    {
        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("ListingType")]
        public string ListingType { get; set; }

        [XmlElement("StartPrice")]
        public AmountType StartPrice { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("MinBuyItNowPricePercent")]
        public double MinBuyItNowPricePercent { get; set; }
    }
}
