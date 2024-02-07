using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("ShippingCostPaidBy")]
    public class ShippingCostPaidBy
    {
        [XmlElement("ShippingCostPaidByOption")]
        public string ShippingCostPaidByOption { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
