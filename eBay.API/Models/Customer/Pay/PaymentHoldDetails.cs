namespace eBay.API.Models.Customer.Pay
{
    public class PaymentHoldDetails
    {
        public DateTime ExpectedReleaseDate { get; set; }

        public int NumOfReqSellerActions { get; set; }

        public string PaymentHoldReason { get; set; }
    }
}
