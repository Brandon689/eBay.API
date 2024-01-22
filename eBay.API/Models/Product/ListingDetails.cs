using System.Xml.Serialization;

namespace eBay.API.Models.Product
{
    public class ListingDetails
    {
        public bool Adult { get; set; }

        public bool BindingAuction { get; set; }

        public bool CheckoutEnabled { get; set; }

        [XmlElement("ConvertedBuyItNowPrice")]
        public AmountType ConvertedBuyItNowPrice { get; set; }

        [XmlElement("ConvertedStartPrice")]
        public AmountType ConvertedStartPrice { get; set; }

        [XmlElement("ConvertedReservePrice")]
        public AmountType ConvertedReservePrice { get; set; }

        public bool HasReservePrice { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string ViewItemURL { get; set; }

        public bool HasUnansweredQuestions { get; set; }

        public bool HasPublicMessages { get; set; }

        public string ViewItemURLForNaturalSearch { get; set; }
    }
}
