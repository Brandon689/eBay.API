using System.Xml.Serialization;

namespace eBay.API.Models.Customer.Ship
{
    public class ShippingServiceSelected
    {
        public string ShippingService { get; set; }

        [XmlElement("ShippingServiceCost")]
        public AmountType ShippingServiceCost { get; set; }

        public ShippingPackageInfo ShippingPackageInfo { get; set; }
    }
}
