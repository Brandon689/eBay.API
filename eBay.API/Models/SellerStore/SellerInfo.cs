namespace eBay.API.Models.SellerStore
{
    public class SellerInfo
    {
        public bool AllowPaymentEdit { get; set; }
        public bool CheckoutEnabled { get; set; }
        public bool CIPBankAccountStored { get; set; }
        public bool GoodStanding { get; set; }
        public bool LiveAuctionAuthorized { get; set; }
        public string MerchandizingPref { get; set; }
        public bool QualifiesForB2BVAT { get; set; }
        public bool StoreOwner { get; set; }
        public bool SafePaymentExempt { get; set; }
    }
}
