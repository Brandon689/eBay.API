namespace eBay.API.Models.Customer
{
    public class CheckoutStatus
    {
        public string EBayPaymentStatus { get; set; }

        public DateTime LastModifiedTime { get; set; }

        public string PaymentMethod { get; set; }

        public string Status { get; set; }

        public string PaymentInstrument { get; set; }
    }
}
