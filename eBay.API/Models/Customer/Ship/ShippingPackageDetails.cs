using eBay.API.Models.Items;

namespace eBay.API.Models.Customer.Ship
{
    public class ShippingPackageDetails
    {
        public bool ShippingIrregular { get; set; }

        public string ShippingPackage { get; set; }

        public WeightMajor WeightMajor { get; set; }

        public WeightMinor WeightMinor { get; set; }
    }
}
