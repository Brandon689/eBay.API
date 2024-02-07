using eBay.API.Models.Response;
using System.Xml.Serialization;

namespace eBay.API.Models
{
    [XmlRoot("GetMyeBaySellingResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetMyeBaySellingResponse : ResponseBase
    {
        [XmlElement("ActiveList")]
        public ActiveList ActiveList { get; set; }

        [XmlElement("SoldList")]
        public SoldList SoldList { get; set; }

        [XmlElement("DeletedFromSoldList")]
        public DeletedFromSoldList DeletedFromSoldList { get; set; }

        [XmlElement("DeletedFromUnsoldList")]
        public DeletedFromUnsoldList DeletedFromUnsoldList { get; set; }

        [XmlElement("HideVariations")]
        public string HideVariations { get; set; }

        [XmlElement("ScheduledList")]
        public ScheduledList ScheduledList { get; set; }

        [XmlElement("SellingSummary")]
        public SellingSummary SellingSummary { get; set; }

        [XmlElement("UnsoldList")]
        public UnsoldList UnsoldList { get; set; }
    }
}
