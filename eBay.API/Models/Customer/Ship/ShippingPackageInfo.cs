namespace eBay.API.Models.Customer.Ship
{
    public class ShippingPackageInfo
    {
        public DateTime EstimatedDeliveryTimeMin { get; set; }

        public DateTime EstimatedDeliveryTimeMax { get; set; }

        public DateTime HandleByTime { get; set; }

        public DateTime MinNativeEstimatedDeliveryTime { get; set; }

        public DateTime MaxNativeEstimatedDeliveryTime { get; set; }

        public DateTime ActualDeliveryTime { get; set; }
    }
}
