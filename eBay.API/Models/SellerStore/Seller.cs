namespace eBay.API.Models.SellerStore
{
    public class Seller
    {
        public bool AboutMePage { get; set; }
        public string Email { get; set; }
        public int FeedbackScore { get; set; }
        public double PositiveFeedbackPercent { get; set; }
        public bool FeedbackPrivate { get; set; }
        public bool IDVerified { get; set; }
        public bool EBayGoodStanding { get; set; }
        public bool NewUser { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Site { get; set; }
        public string Status { get; set; }
        public string UserID { get; set; }
        public bool UserIDChanged { get; set; }
        public DateTime UserIDLastChanged { get; set; }
        public string VATStatus { get; set; }
        public SellerInfo SellerInfo { get; set; }
        public bool MotorsDealer { get; set; }
    }
}
