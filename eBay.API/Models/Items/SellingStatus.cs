using System.Xml.Serialization;

namespace eBay.API.Models.Items
{
    public class SellingStatus
    {
        public int BidCount { get; set; }

        [XmlElement("BidIncrement")]
        public AmountType BidIncrement { get; set; }

        [XmlElement("ConvertedCurrentPrice")]
        public AmountType ConvertedCurrentPrice { get; set; }

        [XmlElement("CurrentPrice")]
        public AmountType CurrentPrice { get; set; }

        public HighBidder HighBidder { get; set; }

        public int LeadCount { get; set; }

        [XmlElement("MinimumToBid")]
        public AmountType MinimumToBid { get; set; }

        public int QuantitySold { get; set; }

        public bool ReserveMet { get; set; }

        public bool SecondChanceEligible { get; set; }

        public string ListingStatus { get; set; }

        public int QuantitySoldByPickupInStore { get; set; }
    }
}
