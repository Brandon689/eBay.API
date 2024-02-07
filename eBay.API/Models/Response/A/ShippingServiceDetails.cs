using eBay.API.Models.Response.NewFolder;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ShippingServiceDetails")]
    public class ShippingServiceDetails
    {
        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("ShippingService")]
        public string ShippingService { get; set; }

        [XmlElement("ShippingServiceID")]
        public int ShippingServiceID { get; set; }

        [XmlElement("ShippingTimeMax")]
        public int ShippingTimeMax { get; set; }

        [XmlElement("ShippingTimeMin")]
        public int ShippingTimeMin { get; set; }

        [XmlElement("ServiceType")]
        public List<string> ServiceType { get; set; }

        [XmlElement("ShippingPackage")]
        public List<string> ShippingPackage { get; set; }

        [XmlElement("DimensionsRequired")]
        public bool DimensionsRequired { get; set; }

        [XmlElement("ValidForSellingFlow")]
        public bool ValidForSellingFlow { get; set; }

        [XmlElement("ShippingServicePackageDetails")]
        public List<ShippingServicePackageDetails> ShippingServicePackageDetails { get; set; }

        [XmlElement("WeightRequired")]
        public bool WeightRequired { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("ShippingCategory")]
        public string ShippingCategory { get; set; }

        [XmlElement("InternationalService")]
        public bool InternationalService { get; set; }

        [XmlElement("ShippingCarrier")]
        public string ShippingCarrier { get; set; }

        [XmlElement("DeprecationDetails")]
        public DeprecationDetails DeprecationDetails { get; set; }

        [XmlElement("MappedToShippingServiceID")]
        public int MappedToShippingServiceID { get; set; }

        [XmlElement("ExpeditedService")]
        public bool ExpeditedService { get; set; }
    }
}
