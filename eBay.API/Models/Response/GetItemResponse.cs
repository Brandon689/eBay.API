using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetItemResponse
    {
        public DateTime Timestamp { get; set; }
        public string Ack { get; set; }
        public int Version { get; set; }
        public string Build { get; set; }
        public Item Item { get; set; }
    }
}
