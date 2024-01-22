using eBay.API.Models.Customer.Pay;
using eBay.API.Models.Customer.Refund;

namespace eBay.API.Models.Customer
{
    public class MonetaryDetails
    {
        public Payments Payments { get; set; }

        public Refunds Refunds { get; set; }
    }
}
