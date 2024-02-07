using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("ShippingPackageDetails")]
    public class ShippingPackageDetails
    {
        [XmlElement("PackageID")]
        public int PackageID { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("ShippingPackage")]
        public string ShippingPackage { get; set; }

        [XmlElement("DimensionsSupported")]
        public bool DimensionsSupported { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
