using eBay.API.Models.Customer.Tax;
using eBay.API.Models.Items;

namespace eBay.API.Models.Customer.Ship
{
    public class ShippingDetails
    {
        public bool ApplyShippingDiscount { get; set; }

        public CalculatedShippingRate CalculatedShippingRate { get; set; }

        public SalesTax SalesTax { get; set; }

        public ShippingServiceOptions ShippingServiceOptions { get; set; }

        public InternationalShippingServiceOption InternationalShippingServiceOption { get; set; }

        public string ShippingType { get; set; }

        public bool ThirdPartyCheckout { get; set; }

        public int ShippingDiscountProfileID { get; set; }

        public int InternationalShippingDiscountProfileID { get; set; }

        public string[] ExcludeShipToLocation { get; set; }

        public bool SellerExcludeShipToLocationsPreference { get; set; }
    }
}
