using eBay.API.Models.Product;
using System.Xml.Serialization;

namespace eBay.API.Models.Items
{
    public class ItemSpecifics
    {
        [XmlElement("NameValueList")]
        public NameValueList[] NameValueList { get; set; }
    }
}
