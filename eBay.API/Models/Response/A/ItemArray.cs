using eBay.API.Models.Items;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ItemArray")]
    public class ItemArray
    {
        [XmlElement("Item")]
        public List<Item> Item { get; set; }
    }
}
