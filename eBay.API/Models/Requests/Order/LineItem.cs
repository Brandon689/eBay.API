using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Order
{
    [XmlRoot("LineItem")]
    public class LineItem
    {
        [XmlElement("CountryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("ItemID")]
        public string ItemID { get; set; }

        [XmlElement("Quantity")]
        public string Quantity { get; set; }

        [XmlElement("TransactionID")]
        public string TransactionID { get; set; }
    }
}
