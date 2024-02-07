using eBay.API.Models.Items;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetItemResponse : ResponseBase
    {
        public Item Item { get; set; }
    }
}
