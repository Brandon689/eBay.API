using System.Xml.Serialization;

namespace eBay.API.Models.Items
{
    public class InternationalShippingServiceOption
    {
        public string ShippingService { get; set; }

        [XmlElement("ShippingServiceCost")]
        public AmountType ShippingServiceCost { get; set; }

        [XmlElement("ShippingServiceAdditionalCost")]
        public AmountType ShippingServiceAdditionalCost { get; set; }

        public int ShippingServicePriority { get; set; }

        public string ShipToLocation { get; set; }
    }
}
