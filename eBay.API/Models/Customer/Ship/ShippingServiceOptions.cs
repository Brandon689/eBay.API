using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Ship
{
    public class ShippingServiceOptions
    {
        public string ShippingService { get; set; }

        [XmlElement("ShippingServiceCost")]
        public AmountType ShippingServiceCost { get; set; }

        [XmlElement("ShippingServiceAdditionalCost")]
        public AmountType ShippingServiceAdditionalCost { get; set; }

        public int ShippingServicePriority { get; set; }

        public bool ExpeditedService { get; set; }

        public int ShippingTimeMin { get; set; }

        public int ShippingTimeMax { get; set; }

        public bool FreeShipping { get; set; }
    }
}
