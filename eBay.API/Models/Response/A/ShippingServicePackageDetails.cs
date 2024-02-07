using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("ShippingServicePackageDetails")]
    public class ShippingServicePackageDetails
    {
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
